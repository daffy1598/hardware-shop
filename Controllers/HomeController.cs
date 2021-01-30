using HardwareShop.Constans;
using HardwareShop.Controllers;
using HardwareShopRole.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HardwareShopRole.Controllers
{
    public class HomeController : BaseDatabaseController
    {
        private readonly UserManager<HardwareShopUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;


        public HomeController(ApplicationDbContext context, UserManager<HardwareShopUser> userManager, RoleManager<IdentityRole> roleManager)
            : base(context)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            await this.SeedUsersandRoles();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private async Task SeedUsersandRoles()
        {
            string[] roleNames = { GlobalConstants.AdminRole, GlobalConstants.UserRole };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            string[] userEmails = { "admin@admin.admin", "user@user.user" }; 
            for (int index = 0; index < userEmails.Length; index++)
            { 
                string userEmail = userEmails[index];
                string userRole = roleNames[index];

                var user = new HardwareShopUser
                { 
                    UserName = userEmail,
                    Email = userEmail,
                    EmailConfirmed = true
                };
                var dbUser = await userManager.FindByEmailAsync(user.Email);
                if (dbUser == null)
                {
                    var newUser = await userManager.CreateAsync(user, "A!a123456");
                    if (newUser.Succeeded)
                    { 
                        await userManager.AddToRoleAsync(user, userRole);
                    }
                }
            }
        }

    }
}