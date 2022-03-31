using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TigerTix.Data;
using TigerTix.ViewModels;

namespace TigerTix.Controllers
{
    public class AppController : Controller
    {
        private readonly TigerTixContext _context;
        public AppController(TigerTixContext context)
        {
            _context = context;
        }

        public IActionResult ShowUsers()
        {
            var results = from u in _context.Users
                          select u;
            return View(results.ToList());
        }

        public IActionResult Index(IndexViewModel model)
        {
            return View();
        }
    }
}
