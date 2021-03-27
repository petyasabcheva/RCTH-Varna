using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Models.ViewModels
{
    public class QuestionnaireInputModel
    {
        [Required(ErrorMessage = "Моля попълнете")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Моля попълнете")]
        public int Weight { get; set; }
        [Required(ErrorMessage ="Моля изберете")]
        public string Healthy { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question3 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question4 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question5 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question6 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question7 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question8 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question9 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question10 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question11 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question12 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question13 { get; set; }
        [Required(ErrorMessage ="Моля изберете")]
        public string Question14 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question15 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question16 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question17 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question18 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question19 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question20 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question21 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question22 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question23 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question24 { get; set; }
        [Required(ErrorMessage = "Моля изберете")]
        public string Question25 { get; set; }
    }
}
