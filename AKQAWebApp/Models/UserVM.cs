using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AKQAWebApp.Models
{
    public class UserVM
    {
        [Required(AllowEmptyStrings=false)]
        [Display(Name = "Name")]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Number")]
        [RegularExpression("^[0-9]\\d{0,9}(\\.\\d{1,3})?%?$", ErrorMessage = "Invalid Number Format. Only digits and period is allowed.")]
        public double UserNumber { get; set; }

        [Display(AutoGenerateField = false)]
        public string ConvertedToWordNumber { get; set; }
    }
}