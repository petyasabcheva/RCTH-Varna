using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RCTH.Areas.Identity.Data;

namespace RCTH.Models.ViewModels
{
    public class ProfileDetailsViewModel
    {
        public DateTime? LastBloodDonation { get; set; }

        [Required]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public string PhoneNumber { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public int Age { get; set; }

        public DateTime? MinDateNextDonation
        {
            get
            {
                if (IsEmpty(LastBloodDonation)) {return null;}
                else
                {
                    DateTime newDate = (DateTime)LastBloodDonation;
                    return newDate.AddMonths(2);
                }
            }
        }

        public List<DonationView> DonationData { get; set; }
        //Donation data
        public class DonationView
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public double Quantity { get; set; }
            public string   Receiver { get; set; }
        }
        




        private static bool IsEmpty(DateTime? dateTime)
        {
            return dateTime == default(DateTime) || dateTime == null;
        }
    }
}
