﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WMart.Models
{
    public class Customer
    {

        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Address")]

        public string Address { get; set; }

        [Required(ErrorMessage = "Enter Mobileno")]

        public string Mobileno { get; set; }

        [DataType(DataType.Date)]

        [Required(ErrorMessage = "Enter Birthdate")]

        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Enter EmailID")]
        public string EmailID { get; set; }
        public List<Customer> ShowallCustomer { get; set; }

    }
}