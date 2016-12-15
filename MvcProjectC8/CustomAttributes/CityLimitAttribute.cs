using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcProjectC8.CustomAttributes
{
    public class CityLimitAttribute : ValidationAttribute
    {
        private readonly string[] allowedCounties;

        public CityLimitAttribute(string[] allowedCities) : base($"Only the following cities are allowed: {string.Join(", ", allowedCities)}")
        {
            this.allowedCounties = allowedCities;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var valueAsString = value.ToString();
            if (!allowedCounties.Contains(valueAsString))
            {
                var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                return new ValidationResult(errorMessage);
            }
            return ValidationResult.Success;
        }
    }
}