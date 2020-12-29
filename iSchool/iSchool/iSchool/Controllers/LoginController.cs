using iSchool.Models;
using iSchool.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iSchool.Controllers
{
    public class LoginController : Controller
    {
        public readonly ILogin _repo;
        public LoginController(ILogin repo)
        {
           _repo= repo ;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginRR(LoginModel model)
        {
            var chk= _repo.GetLogin(model);
            
            if (chk==true)
            {
               return Json(true);
            }
            else
            {
               return Json(false);
            }
            
            
        }
    }
}
