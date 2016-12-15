using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectC8.Models
{
    [Bind(Exclude = "Country")]
    public class ProjectEvaluation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "User's city name")]
        public string City { get; set; }
        public string Country { get; set; }

        [Required]
        [Range(1, 10)]
        public int Rating { get; set; }
    }
}