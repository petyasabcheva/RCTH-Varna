using Microsoft.AspNetCore.Mvc;
using System.Linq;
using RCTH.Data;
using RCTH.Models.ViewModels;

namespace RCTH.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly RCTHContext _db;
        public ArticlesController(RCTHContext db)
        {
            _db = db;
        }

        public IActionResult All()
        {
            var viewModel = new ArticleListViewModel()
            {
                Articles = this._db.Articles.Select(x => new ArticleViewModel()
                {
                    Id = x.Id,
                    Content = x.Content,
                    AuthorName = x.AuthorName,
                    Title = x.Title,
                    DateCreated = x.DateCreated.ToString()
                })
                .ToList().OrderByDescending(x => x.DateCreated)
            };

            return View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var item = this._db.Articles.Where(x => x.Id == id).Select(x => new ArticleViewModel()
            {
                Id = x.Id,
                Content = x.Content,
                AuthorName = x.AuthorName,
                Title = x.Title,
                DateCreated = x.DateCreated.ToString()
            }).FirstOrDefault();

            if (item == null)
            {
                return this.NotFound();
            }

            return this.View(item);
        }


    };
}

