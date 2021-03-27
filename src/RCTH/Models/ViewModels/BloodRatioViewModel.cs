using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Models.ViewModels
{
    public class BloodRatioViewModel
    {

        [Required] private double TotalQuantity;
        [Required] private double QuantityA;
        [Required] private double QuantityB;
        [Required] private double QuantityAB;
        [Required] private double Quantity0;

        public BloodRatioViewModel(double total, double a, double b, double ab, double o)
        {
            TotalQuantity = total;
            QuantityA = a;
            QuantityB = b;
            QuantityAB = ab;
            Quantity0 = o;
        }

        public double PercentageA
        {
            get
            {
                return (QuantityA / TotalQuantity) * 100;
            }
        }
        public double PercentageB
        {
            get
            {
                return (QuantityB / TotalQuantity) * 100;
            }
        }
        public double PercentageAB
        {
            get
            {
                return (QuantityAB / TotalQuantity) * 100;
            }
        }
        public double Percentage0
        {
            get
            {
                return (Quantity0 / TotalQuantity) * 100;
            }
        }
    }
}
