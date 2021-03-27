using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RCTH.Areas.Identity.Data;
using RCTH.Data;
using RCTH.Models.ViewModels;

namespace RCTH.Controllers
{
    public class ProfileController : Controller
    {
        private readonly RCTHContext _db;
        public ProfileController(RCTHContext db)
        {
            _db = db;
        }
        public IActionResult Details()
        {
            var userId = _db.RCTHUsers
                .FirstOrDefault(u => u.UserName == User.Identity.Name)
                .Id;
            //get required user data from database
            ProfileDetailsViewModel model = _db.RCTHUsers
                .Include(u => u.BloodGroup)
                .Select(u => new ProfileDetailsViewModel()
                {
                    UserName = u.UserName,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    BloodGroup = u.BloodGroup,
                    PhoneNumber = u.PhoneNumber
                })
                .FirstOrDefault(u => User.Identity.Name == u.UserName);
            //check if user has made a donation then update his bloodgroup 
            if (model.BloodGroup == null)
            {
                model.BloodGroup = _db.Donations
                    .Include(d => d.BloodGroup)
                    .Where(d => d.UserId == userId)
                    .OrderByDescending(d => d.dateDonated)
                    .Select(d => d.BloodGroup)
                    .FirstOrDefault();

                //update user's bloodgroup after a successful bloodtest
                _db.RCTHUsers
                        .Include(u => u.BloodGroup)
                        .FirstOrDefault(u => u.Id == userId)
                        .BloodGroup = model.BloodGroup;
                _db.SaveChanges();
            }
            var donationView = _db.Donations
                .Where(d => d.UserId == userId)
                .OrderByDescending(d => d.dateDonated)
                .Select(d => new ProfileDetailsViewModel.DonationView()
                {
                    Date = d.dateDonated,
                    Id = d.Id,
                    Quantity = d.Quantity,
                    Receiver = d.Receiver
                })
                .ToList();

            //Assign Donation Data
            model.DonationData = donationView;
            model.LastBloodDonation = donationView.Select(d => d.Date).FirstOrDefault();
            //create view model
            return View("Details", model);
        }
    }
}
