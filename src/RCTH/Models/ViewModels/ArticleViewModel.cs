using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RCTH.Models.ViewModels
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public string DateCreated { get; set; }

        public string ShortContent
        {
            get
            {
                return Content.Length > 300
                    ? Content.Substring(0, 300) + "..."
                    : Content;
            }
        }
    }
}
