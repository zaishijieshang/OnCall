using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnCall.Web.Code.Login;
using OnCall.Web.Models;

namespace OnCall.Web.Controllers
{
    public class HomeController : BaseController
    {

        private ILoginManager _LoginManager;

        public HomeController(ILoginManager LoginManager)
        {
            ViewBag.WebTitle = "On Call";
            _LoginManager = LoginManager;
        }

        public IActionResult Index()
        {
            ViewBag.LoginUserName = _LoginManager.LoginAccountName();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
