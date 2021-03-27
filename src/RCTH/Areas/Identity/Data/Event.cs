using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Areas.Identity.Data
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string EventTitle { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
    }
}
