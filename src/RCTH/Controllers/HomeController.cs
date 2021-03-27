using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RCTH.Data;
using RCTH.Models;
using RCTH.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
            var viewModel = new ArticleListViewModel()
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

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
