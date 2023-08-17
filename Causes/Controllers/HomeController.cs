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
    public class HomeController : Controller
    {
        // Instantiate the DB context class, for control over the database with EntityFramework
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //All the causes with more than (popularThreshold) signatures are added to the view specific model to be display in the view
        public ActionResult Index()
        {
            //Minimum number of signatures for a cause to be shown in the homepage
            int popularThreshold = 0;

            //Populate a list with all the causes from the DBcontext, this avoid concurrency issues later on
            var causes = _context.Causes.ToList();

            // Instance of the model to pass to the view
            var viewmodel = new List<PopularCauseViewModel>();

            // Populate the model 
            foreach (var cause in causes)
            {
                var signList = _context.Signatures.Where(s => s.CauseId == cause.Id);
                var list = signList.ToList();
                int count = list.Count;

                // Only causes with more than popularThreshold signatures, are added to the view specific model List
                if (count >= popularThreshold)
                {
                    var data = new PopularCauseViewModel
                    {
                        Cause = cause,
                        SignaturesCount = count
                    };

                    viewmodel.Add(data);
                }
            }

            return View("Home", viewmodel);
        }
    }
}