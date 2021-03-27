using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RCTH.Areas.Identity.Data;
using RCTH.Data;
using RCTH.ViewModels;

namespace RCTH.Controllers
{
    public class AppointmentsController : Controller
    {
        private RCTHContext db;
        public AppointmentsController(RCTHContext _db)
        {
            this.db = _db;
        }
        public IActionResult Create()
        {
            return View("AppointmentForm");
        }
        [HttpPost]
        public IActionResult RegisterDonationRequestNonAuthenticated(UserDonatorViewModel inputData)
        {
            Appointment newAppointment = new Appointment();
            newAppointment.FirstName = inputData.FirstName;
            newAppointment.LastName = inputData.LastName;
            newAppointment.PhoneNumber = inputData.PhoneNumber;
            db.Appointments.Add(newAppointment);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult RegisterDonationRequestAuthenticated(UserDonatorViewModel inputData)
        {
            Appointment newAppointment = new Appointment();
            newAppointment.PhoneNumber = inputData.PhoneNumber;
            var userData = db.Users
                .Where(u => u.UserName == User.Identity.Name)
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName
                })
                .FirstOrDefault();
            newAppointment.FirstName = userData.FirstName;
            newAppointment.LastName = userData.LastName;
            db.Appointments.Add(newAppointment);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
