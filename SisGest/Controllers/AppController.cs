using System;
using Microsoft.AspNetCore.Mvc;


namespace SisGest.Controllers
{
    public class AppController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult forgot()
        {
            return View();
        }
    }
}
