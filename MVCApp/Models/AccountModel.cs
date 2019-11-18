using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class AccountModel
    {
        [Display(Name = "Account ID")]
        [Range(100,99999,ErrorMessage = "You must enter a valid Account ID")]
        public int AccountId { get; set; }

        [Display(Name = "Name")]
        public string AccountName { get; set; }

        [Display(Name = "Street")]
        public string Street { get; set; }
        
        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State/Province")]
        public string StateProvince { get; set; }
        
        [Display(Name = "Country")]
        public string Country { get; set; }
       
    }
}