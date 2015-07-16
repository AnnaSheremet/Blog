using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Blog.Repositories;
using System.Configuration;

namespace Blog.WebUI.Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleRepository _articleRepository;

        public HomeController()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyBlog"].ConnectionString;
            this._articleRepository = new EFArticleRepository(connectionString);

        }

        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            var articles = this._articleRepository.GetPublished();
            return View();
        }

    }
}
