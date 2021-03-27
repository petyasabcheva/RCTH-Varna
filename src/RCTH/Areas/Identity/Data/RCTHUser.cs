using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RCTH.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the RCTHUser class
    public class RCTHUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public int? BloodGroupId { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public string? PhoneNumber { get; set; }
        [Required]
        public string EGN { get; set; }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - BirthDate.Year;
                if ((now.Month == BirthDate.Month && now.Day < BirthDate.Day) || now.Month < BirthDate.Month)
                {
                    age--;
                }

                return age;
            }
        }
    }
}
