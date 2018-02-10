using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WMart.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="User Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email is Required")]
        [RegularExpression(".+\\@.+\\..+",
         ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required (ErrorMessage ="Phone is Required")]
        public string Phone { get; set; }
        [Required (ErrorMessage ="Please state your avilability?")]
        public bool? willAttend { get; set; }
    }
}