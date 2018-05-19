using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AKQAWebApi.Models
{
    public class UserVM
    {
        public string UserName { get; set; }
        public double UserNumber { get; set; }
        public string ConvertedToWordNumber { get; set; }
    }
}