using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Models.ViewModels
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string EventTitle { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
    }
}
