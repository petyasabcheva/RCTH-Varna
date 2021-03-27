using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Areas.Identity.Data
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
