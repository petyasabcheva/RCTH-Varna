using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Areas.Identity.Data
{
    public class Donation
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public RCTHUser User { get; set; }
        [Required]
        public string EGN { get; set; }
        [Required]
        public DateTime dateDonated { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public int BloodGroupId { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public string Receiver { get; set; }
		//public int MedResultId { get;set; }
		//public MedResult MedResult { get; set; }
    }
}
