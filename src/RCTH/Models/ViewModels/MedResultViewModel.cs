using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RCTH.Areas.Identity.Data;

namespace RCTH.Models.ViewModels
{
    public class MedResultViewModel
    {
        [Required]
        public List<MedResult> MedResults { get; set; }
    }
}
