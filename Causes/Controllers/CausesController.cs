using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Causes.Models;
using Causes.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Causes.Controllers
{
    public class CausesController : Controller
    {   

        // Instantiate the DB context class, for control over the database with EntityFramework
        private ApplicationDbContext _context;

        public CausesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()

        {   
            // Collect all the causes into a List to send to the view as a model
            var causes = _context.Causes.ToList();

            // Check if the Admin is logged in, to route the request to the Admin Page, with additional functionality
            bool isAdmin = User.IsInRole("CanManageCauses");

            if (isAdmin) {

                return View("AdminIndex", causes);
            } 

            return View(causes);
        }

        // This annotation allow only logged in user to access this controller and display the Create Cause Form
        [Authorize]
        public ActionResult New()
        {

            var causeTypes = _context.CauseTypes.ToList();

            var viewmodel = new CreateCauseViewModel
            {
                CauseTypes = causeTypes
            };

            return View("Create", viewmodel);
        }

        // Assert the request is a POST HTTP request, for added security
        // Send the data inserted by the user to this controller, which insert the Cause into the DB
        [HttpPost]
        // The controller will fit the POSTed form data to the Cause cause instance
        public ActionResult Create(Cause cause)
        {
            // Creation of a new instance of Cause() to save into the database
            var user = User.Identity.GetUserId();
            var type = _context.CauseTypes.Single(c => c.Id == cause.CauseTypeId);

            cause.CreatorName = _context.Users.Single(u => u.Id == user).FullName;
            cause.CreatorId = user;
            cause.CauseTypeName = type.Type;

            // Add and save to the database with EntityFramework
            _context.Causes.Add(cause);
            _context.SaveChanges();

            return RedirectToAction("Index", "Causes");
        }


        // Creates the Edit Page for the Cause
        // The id can be inserted directly into the URL, thanks to the routing default recognizing ID parameters
        public ActionResult Edit(int? id)
        {
            // Collect the requested Cause() to display the specific Edit page
            var cause = _context.Causes.SingleOrDefault(c => c.Id == id);
            if (cause == null) return HttpNotFound();

            // Specific view Model, the view will be able to access the sent Cause and the possible CauseType
            var viewModel = new CreateCauseViewModel
            {
                Cause = cause,
                CauseTypes = _context.CauseTypes.ToList()
            };

            return View(viewModel);
        }

        // Assert the request is a POST HTTP request, for added security
        // Change the database data
        [HttpPost]
        public ActionResult Edit(CreateCauseViewModel model)
        {
            // Use linq to find the Cause to edit
            var causeInDB = _context.Causes.Single(c => c.Id == model.Cause.Id);

            var editToThis = model.Cause;

            // Change the attributes 
            causeInDB.Title = editToThis.Title;
            causeInDB.Description = editToThis.Description;
            causeInDB.CauseTypeId = editToThis.CauseTypeId;

            // Save in the database
            _context.SaveChanges();

            return RedirectToAction("Index", "Causes");

        }

        // Assert the Delete Controller is being used by the Admin, or any user with CanManageCauses privileges
        [Authorize(Roles = "CanManageCauses")]
        public ActionResult Delete(int id)
        {   
            // Get the cause
            var causeInDB = _context.Causes.Single(c => c.Id == id);

            // Remove it and save the database change
            _context.Causes.Remove(causeInDB);
            _context.SaveChanges();

            return RedirectToAction("Index", "Causes");

        }

        // Only LoggedIn users can sign the Causes
        [Authorize]
        public ActionResult Sign(int id)
        {
            var userId = User.Identity.GetUserId();

            // Check if the user already signed the cause
            if (_context.Signatures.Any(s => s.UserId == userId &&
                s.CauseId == id))
            {
                // Warn the user it is not possible to sign the cause twice

                return Content("<script language='javascript' type='text/javascript'>alert('You have already signed this cause! You can sign any cause only once.');" +
                                "location.href='/';</script>");
            }
            // If the user did not sign, we add a Signature instance to the Signatures table, which connects a UserID to a CauseID
            else
            {
                var user = _context.Users.SingleOrDefault(c => c.Id == userId);

                string name = user.FullName;

                Signatures toAdd = new Signatures
                {
                    UserId = userId,
                    CauseId = id,
                    UserFullName = name
                };

                _context.Signatures.Add(toAdd);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
        }


        // Display the details of a single Cause with all the Signatures
        public ActionResult Details(int? id)
        {   
            // Get the cause from the database with linq
            var cause = _context.Causes.SingleOrDefault(c => c.Id == id);

            // Send a 404 response if the cause could not be found
            if (cause == null) return HttpNotFound();

            var user = _context.Users.Single(u => u.Id == cause.CreatorId);

            var name = user.FullName;

            var signList = _context.Signatures.Where(s => s.CauseId == cause.Id);

            // Instantiate a view specific Model to join the list of Signature for the cause, and the Cause object
            var viewmodel = new DetailsCauseViewModel
            {
                Cause = cause,
                SignaturesList = signList.ToList()


            };

            return View(viewmodel);
        }


       
        }
    }


