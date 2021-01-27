
using HardwareShop.Constans;
using HardwareShopRole.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace HardwareShop.Areas.Admin.Controllers
{
    [Area(GlobalConstants.AdminArea)]
    [Authorize(Roles = GlobalConstants.AdminRole)]
    public class BaseAdminController : Controller
    {
        public BaseAdminController(ApplicationDbContext context)
        {
            this.DbContext = context;
        }
        
        public ApplicationDbContext DbContext { get; private set; }
    }

}
