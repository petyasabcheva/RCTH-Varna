using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Models.ViewModels
{
    public class ArticleListViewModel
    {
        public IEnumerable<ArticleViewModel> Articles { get; set; }
    }
}
