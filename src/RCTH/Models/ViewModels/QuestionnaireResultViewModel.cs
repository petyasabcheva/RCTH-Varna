using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Models.ViewModels
{
    public class QuestionnaireResultViewModel
    {
        public bool CanDonateBool { get; set; }

        public string CanDonate => "Според отговорите, дадени от Вас, Вие сте в добро здравословно състояние и можете да дарите кръв.";
        public string CanNotDonate => "Според отговорите, дадени от Вас, в момента не можете да дарите кръв. За допълнителна консултация можете да се свържете с кръвния център.";

    }
}
