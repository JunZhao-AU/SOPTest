using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp_GoodBank.Models;

namespace WebApp_GoodBank.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Account()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Account(string amount)
        {
            return Content(amount);
        }

        public IActionResult GetBankCapital()
        {
            return Json("One Trillion Dollars");
        }

        [HttpPost]
        public IActionResult UpdateUserName([FromBody] UserInfo userInfo)
        {
            var localDb = new Dictionary<int, string>();
            localDb.Add(userInfo.UserId, userInfo.UserName);
            return Json("OK");
        }

        [HttpGet]
        public IActionResult Greetings()
        {
            return View("GreetingsForm");
        }

        [HttpPost]
        public IActionResult Greetings(string userName)
        {
            ViewBag.UserName = userName; 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public class UserInfo
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
        }
    }
}
