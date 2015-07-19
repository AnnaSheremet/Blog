using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Blog.Repositories;
using System.Configuration;
using Blog.Entities;

namespace Blog.WebUI.Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly EFArticleRepository _articleRepository;

        public HomeController()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["MyBlog"].ConnectionString;
            //this._articleRepository = new EFArticleRepository(connectionString);
            this._articleRepository = new EFArticleRepository();

        }

        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            List<Article> articles = this._articleRepository.GetPublished();
            return View();
        }

    }
}
