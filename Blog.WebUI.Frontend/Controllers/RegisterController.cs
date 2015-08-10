using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

using Blog.Entities;
using Blog.Repositories;
using Blog.WebUI.Frontend.Models;

namespace Blog.WebUI.Frontend.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        private readonly EFUserRepository _userRepository;

        public RegisterController()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BlogEntities"].ConnectionString;
            this._userRepository = new EFUserRepository(connectionString);
        }
        [HttpGet]
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegisterUserModel user)
        {
            if (ModelState.IsValid)
            {
                //Users _user = new Users();
                //_user.Fist_name = user.Fist_name;
                //_user.Surname = user.Surname;
                //_user.Login = user.Login;
                //_user.Password = user.Password;
                //this._userRepository.AddUser(_user);
                return RedirectToAction("Index", "Home");

            }
            return View();
        }
    }
}
