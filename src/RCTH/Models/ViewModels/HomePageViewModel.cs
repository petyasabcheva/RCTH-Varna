using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Models.ViewModels
{
    public class HomePageViewModel
    {
        [Required] public BloodRatioViewModel BloodRatio { get; set; }
        [Required] public ArticleListViewModel ArticleList { get; set; }
        [Required] public EventListViewModel EventList { get; set; }
    }
}
