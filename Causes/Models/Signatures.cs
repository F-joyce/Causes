using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Causes.Models
{
    public class Signatures
    {
        public int Id { get; set; }
        
        [Required]
        public string UserId { get; set; }
        [Required]
        public int CauseId { get; set; }

        public string UserFullName { get; set; }
    }
}