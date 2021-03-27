using Microsoft.AspNetCore.Mvc;
using RCTH.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Controllers
{
    public class QuestionnaireController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(QuestionnaireInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }
            var questions = new string[]
            {
                input.Question4,
                input.Question5,
                input.Question6,
                input.Question7,
                input.Question8,
                input.Question9,
                input.Question10,
                input.Question11,
                input.Question12,
                input.Question13,
                input.Question14,
                input.Question15,
                input.Question16,
                input.Question17,
                input.Question18,
                input.Question19,
                input.Question20,
                input.Question21,
                input.Question22,
                input.Question23,
                input.Question24,
            };

            var result = new QuestionnaireResultViewModel();
            if (questions.All(x => x == "false")&&input.Age>=18&&input.Weight>=60&&input.Healthy=="true")
            {
                return this.Redirect("/Questionnaire/CanDonate");
            }

            return this.Redirect("/Questionnaire/CanNotDonate");
   

        }
        public IActionResult CanDonate()
        {
            return this.View();
        }

        public IActionResult CanNotDonate()
        {
            return this.View();
        }
    }

}
