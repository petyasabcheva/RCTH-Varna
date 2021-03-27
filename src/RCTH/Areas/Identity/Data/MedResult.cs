using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Areas.Identity.Data
{
    public class MedResult
    {
        public int Id { get; set; }
        public Donation Donation { get; set; }

        [Required]
        public int DonationId { get; set; }
        public DateTime dateReleased { get; set; }
    }
}
