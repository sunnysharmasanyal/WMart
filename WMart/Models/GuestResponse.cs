using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WMart.Models
{
    public class GuestResponse
    {
        
        public int CId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        public string CEmail { get; set; }

        [Required(ErrorMessage = "Phone is required.")]
        public string CPhone { get; set; }


        public string Status { get; set; }
    }
}