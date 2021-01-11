using Microsoft.AspNetCore.Identity;
using System;

namespace HardwareShopRole.Models.Account
{
    public class HardwareShopRole :IdentityRole
    {
        public HardwareShopRole()
        {

        }
        public string FavouriteComputer { get; set; }

      
    }
}
