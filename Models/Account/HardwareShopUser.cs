using Microsoft.AspNetCore.Identity;
using System;

namespace HardwareShopRole.Models.Account
{
    public class HardwareShopUser : IdentityUser
    {
        public HardwareShopUser()
        {
        }

        public string FavouriteComputer { get; set; }
    }
}
