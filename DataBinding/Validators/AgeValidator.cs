using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DataBinding.Validators
{
    public class AgeValidator : ValidationRule
    {
        public int Max { get; set; }
        public int Min { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int age;
            bool done;

            done = int.TryParse(value.ToString(), out age);
            if (done || String.IsNullOrEmpty(value.ToString()))
            {
                ValidationResult result = (age > Min && age < Max) ? new ValidationResult(true, null) : new ValidationResult(false, $"Invalid Number, must be between {Min} - {Max}");
                return result;
            }
            else return new ValidationResult(false, "Invalid Age");
        }
    }
}
