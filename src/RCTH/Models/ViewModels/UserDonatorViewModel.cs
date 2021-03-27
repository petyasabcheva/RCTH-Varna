using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.ViewModels
{
    public class UserDonatorViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required] public string PhoneNumber { get; set; }


    }
}
