using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RCTH.Areas.Identity.Data
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Заглавие")]
        public string Title { get; set; }
        [DisplayName("Съдържание")]
        public string Content { get; set; }
        [DisplayName("Автор")]
        public string AuthorName { get; set; }
        [DisplayName("Дата на създаване")]
        public DateTime DateCreated { get; set; }

    }
}
