using CETApp.Models;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CETApp.Controllers
{
    public class UserController : Controller
    {
        private static ICETRepo _repo;

        CETRepo cETRepo = new CETRepo();

        public UserController(ICETRepo repo)
        {
            _repo = repo;
        }



        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegisterUser(UserDetails user)
        {
            if (ModelState.IsValid)
            {
                DataAccess.Model.UserDetails temp = new
                    DataAccess.Model.UserDetails();
                temp.UserFirstName = user.FirstName;
                temp.UserLastName = user.LastName;
                temp.UserEmailId = user.EmailId;
                temp.UserPassword = user.Password;

                bool result = _repo.RegisterUser(temp);

                if (!result)
                    View("Error");
                else ViewBag.Message = "Registered";
            }
            return View();
        }



        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string emailid, string password)
        {
            DataAccess.Model.UserDetails user
                = cETRepo.AuthenticateUser(emailid, password);

            if (user != null)
            {
                HttpContext.Session.SetString("emailid", emailid);
                HttpContext.Session.SetString("password", password);
                return RedirectToAction("AddEmployee", "CET");
            }
            else
            {
                ViewBag.error = "Invalid Username and Password";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "User");

        }
     }


}

