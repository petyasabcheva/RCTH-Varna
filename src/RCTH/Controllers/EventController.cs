using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RCTH.Data;
using RCTH.Models.ViewModels;

namespace RCTH.Controllers
{
    public class EventController : Controller
    {
        private readonly RCTHContext _db;
        public EventController(RCTHContext db)
        {
            _db = db;
        }
        public IActionResult AllEvents()
        {
            var viewModel = new EventListViewModel()
            {
                Events = this._db.Events.Select(x => new EventViewModel()
                {
                    Id = x.Id,
                    Description = x.Description,
                    Location = x.Location,
                    EventTitle = x.EventTitle,
                    Date = x.Date,
                })
                    .Where(e => e.Date >= DateTime.Now)
                    .OrderBy(x => x.Date)
                    .ToList()
            };

            return View(viewModel);
        }

        public IActionResult ByIdEvent(int id)
        {
            var item = this._db.Events.Where(x => x.Id == id).Select(x => new EventViewModel()
            {
                Id = x.Id,
                Description = x.Description,
                Location = x.Location,
                EventTitle = x.EventTitle,
                Date = x.Date,
            }).FirstOrDefault();

            if (item == null)
            {
                return this.NotFound();
            }

            return this.View(item);
        }

    }
}
