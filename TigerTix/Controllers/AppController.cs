using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TigerTix.Data;
using TigerTix.Data.Entities;
using TigerTix.ViewModels;

namespace TigerTix.Controllers
{
    public class AppController : Controller
    {
        private readonly IUserRepository _userRepository;
        public AppController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult ShowUsers()
        {
            var results = from u in _userRepository.GetAllUsers()
                          select u;
            return View(results.ToList());
        }

        public IActionResult Index(User user)
        {
            _userRepository.SaveUser(user);
            _userRepository.SaveAll();

            return View();
        }
    }
}
