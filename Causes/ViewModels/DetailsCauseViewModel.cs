using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Causes.Models;

namespace Causes.ViewModels
{
    // View specific model to join a Cause with the Signatures

    public class DetailsCauseViewModel
    {
        public Cause Cause { get; set; }
        public IEnumerable<Signatures> SignaturesList { get; set; }

    }
}