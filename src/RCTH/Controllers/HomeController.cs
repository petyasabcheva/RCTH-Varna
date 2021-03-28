using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RCTH.Data;
using RCTH.Models;
using RCTH.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RCTH.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RCTHContext _db;
 
        public HomeController(ILogger<HomeController> logger, RCTHContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var viewModel = new HomePageViewModel();
            var articleModel = new ArticleListViewModel()
            {
                Articles = this._db.Articles.Select(x => new ArticleViewModel()
                {
                    Id = x.Id,
                    Content = x.Content,
                    AuthorName = x.AuthorName,
                    Title = x.Title,
                    DateCreated = x.DateCreated.ToString()
                }).ToList().OrderByDescending(x => x.DateCreated).Take(3)
            };
            //insert blood ratio data into view model
            var donations = _db.Donations.Include(d => d.BloodGroup);
            double TotalBloodQuantity = donations
                .Select(d => d.Quantity).ToList().Sum();
            double BloodGroupA = donations
                .Where(d => d.BloodGroup.Name == "A+" || d.BloodGroup.Name == "A-")
                .Select(d => d.Quantity).ToList().Sum();
            double BloodGroupB = donations
                .Where(d => d.BloodGroup.Name == "B+" || d.BloodGroup.Name == "B-")
                .Select(d => d.Quantity).ToList().Sum();
            double BloodGroupAB = donations
                .Where(d => d.BloodGroup.Name == "AB+" || d.BloodGroup.Name == "AB-")
                .Select(d => d.Quantity).ToList().Sum();
            double BloodGroup0 = donations
                .Where(d => d.BloodGroup.Name == "0+" || d.BloodGroup.Name == "0-")
                .Select(d => d.Quantity).ToList().Sum();



            viewModel.ArticleList = articleModel;
            viewModel.BloodRatio = new BloodRatioViewModel(TotalBloodQuantity, BloodGroupA, BloodGroupB, BloodGroupAB, BloodGroup0);
                
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
