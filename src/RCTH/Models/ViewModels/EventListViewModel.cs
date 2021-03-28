using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RCTH.Areas.Identity.Data;

namespace RCTH.Models.ViewModels
{
    public class EventListViewModel
    {
        [Required]
        public List<EventViewModel> Events { get; set; }
    }
}
