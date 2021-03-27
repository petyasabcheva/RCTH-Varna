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
        [Required]
        public DateTime dateReleased { get; set; }
        [Required]
        public bool HIV { get; set; }
        [Required]
        public bool HepatitisB { get; set; }
        [Required]
        public bool HepatitisC { get; set; }
        [Required]
        public bool Syphilis { get; set; }
        public bool? PCR { get; set; }
        [Required]
        public string Doctor { get; set; }
    }
}
