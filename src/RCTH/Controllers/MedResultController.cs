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
    public class MedResultController : Controller
    {
        private readonly RCTHContext _db;
        public MedResultController(RCTHContext db)
        {
            _db = db;
        }
        public IActionResult MedResult()
        {
            var userId = _db.RCTHUsers.FirstOrDefault(u => u.UserName == User.Identity.Name).Id;
            List<MedResult> MedResultData = _db.MedResults
                .Include(r => r.Donation)
                .Where(r => r.Donation.UserId == userId)
                .ToList();
            var viewModel = new MedResultViewModel();
            viewModel.MedResults = MedResultData;
            return View(viewModel);
        }


    }
}
