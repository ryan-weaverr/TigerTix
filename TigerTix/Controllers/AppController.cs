using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TigerTix.ViewModels;

namespace TigerTix.Controllers
{
    public class AppController : Controller
    {
        [HttpPost("/")]
        public IActionResult Index(IndexViewModel model)
        {
            return View();
        }
    }
}
