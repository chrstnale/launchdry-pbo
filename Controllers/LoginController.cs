using Launchdry.Models;
using Launchdry.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Launchdry.Controllers 

    // Controller ini dibuat untuk mengatasi permintaan otentikasi pada awal page aplikasi
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public string Login(UserModel userModel)
        {
            SecurityService securityService = new SecurityService();
            Boolean success = securityService.Authenticate(userModel);

            if (success)
            {
                return "Login Berhasil";
            } 
            else
            {
                return "Login Gagal";
            }

        }
    }
}