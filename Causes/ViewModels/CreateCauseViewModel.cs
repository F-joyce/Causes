using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Causes.Models;

namespace Causes.ViewModels
{
    // View specific model to join a Cause with the available CauseTypes
    public class CreateCauseViewModel
    {
        public Cause Cause { get; set; }
        public IEnumerable<CauseType> CauseTypes { get; set; }
        
    }
}