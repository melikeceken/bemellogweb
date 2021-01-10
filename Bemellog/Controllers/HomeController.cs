using Bemellog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bemellog.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<webuser> _userManager;

       public HomeController(ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager, UserManager<webuser> userManager)
        {
            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
        }

       public async Task<ActionResult> CreateRole(string role)
        {
            await _roleManager.CreateAsync(new IdentityRole(role));
            return Ok();
        }
        public async Task<ActionResult> AddRole(string username,string role)
        {
            var user = await _userManager.FindByNameAsync(username);
            await _userManager.AddToRoleAsync(user, role);
            return Ok();
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]




        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details()
        {
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
