using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MVCDemo.Models.Registration
{
    public class Customer
    {

        public int CustomerID { get; set; }
      
        [Required(ErrorMessage ="Name required")]
        public String CustomerName { get; set; }

        public string CustomerAddressLine1 { get; set; }
        public string CustomerAddressLine2 { get; set; }
        public string CustomerAddressLine3 { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
    }
}