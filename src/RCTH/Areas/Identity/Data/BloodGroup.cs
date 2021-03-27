using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Areas.Identity.Data
{
    public class BloodGroup
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
