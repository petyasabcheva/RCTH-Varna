using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminRedirect()
        {
            return View();
        }
    }
}
