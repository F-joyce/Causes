using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Causes.Models;

namespace Causes.Models
{

    // The most important Class for the website, during development some parameters where added for easy access and to reduce the use of queries to the database
    public class Cause
    {
        [Required]
        public int Id  { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }

        public string CauseTypeName { get; set; }
        
        // This Data Annotation allows to display a specific string when Asp.net helpers are used
        [Display(Name="Cause Type")]
        public byte CauseTypeId { get; set; }

        [Required]
        public string CreatorId { get; set; }

        public string CreatorName { get; set; }

        
    }


}