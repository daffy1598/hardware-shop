
using HardwareShopRole.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HardwareShopRole.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<HardwareShopUser> userManager;
        private readonly ApplicationDbContext context;
        public HomeController(UserManager<HardwareShopUser> userManager, ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
