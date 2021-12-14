using System;
using Microsoft.AspNetCore.Mvc;


namespace SisGest.Controllers
{
    public class CordinadorController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
