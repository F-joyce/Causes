using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Causes.ViewModels;
using Causes.Models;

namespace Causes.ViewModels
{
    // View specific model to join a Cause with the count of Signatures

    public class PopularCauseViewModel
    {
        public Cause Cause { get; set; }
        public int SignaturesCount { get; set; }
    }
}