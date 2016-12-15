using MvcProjectC8.CustomAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectC8.Models
{
    [Bind(Exclude = "Country")]
    public class ProjectEvaluation : IValidatableObject
    {
        public int Id { get; set; }

        [MaxWords(3)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "User's city name")]
        [CityLimit(new string[] { "Cluj-Napoca", "Sibiu", "Targu-Mures", "Brasov" })]
        public string City { get; set; }

        public string Country { get; set; }

        [Required]
        [Range(1, 10)]
        public int Rating { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validatonContext)
        {
            if (Rating < 2 && Name.ToLower().StartsWith("john"))
            {
                yield return new ValidationResult("Sorry John, you can’t do this");
            }
        }
    }
}