using Microsoft.AspNetCore.Mvc;
using RCTH.Areas.Identity.Data;
using RCTH.Data;
using RCTH.Models.ViewModels;

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
        public IActionResult Create(AppointmentInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }
            var appointment = new Appointment()
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                PhoneNumber = input.PhoneNumber,
                DateAndTime = input.DateAndTime
            };
            db.Appointments.Add(appointment);
            db.SaveChanges();
            return this.Redirect("AppointmentCreated");
        }
        public IActionResult AppointmentCreated()
        {
            return View("AppointmentCreated");
        }

        //[HttpPost]
        //public IActionResult RegisterDonationRequestAuthenticated(CreateAppointmentInputModel inputData)
        //{
        //    Appointment newAppointment = new Appointment();
        //    newAppointment.PhoneNumber = inputData.PhoneNumber;
        //    var userData = db.Users
        //        .Where(u => u.UserName == User.Identity.Name)
        //        .Select(u => new
        //        {
        //            FirstName = u.FirstName,
        //            LastName = u.LastName
        //        })
        //        .FirstOrDefault();
        //    newAppointment.FirstName = userData.FirstName;
        //    newAppointment.LastName = userData.LastName;
        //    db.Appointments.Add(newAppointment);
        //    db.SaveChanges();
        //    return RedirectToAction("Index", "Home");
        //}
    }
}
