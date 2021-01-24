using HardwareShopRole.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareShop.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        public HomeController(ApplicationDbContext context)
            : base(context)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
