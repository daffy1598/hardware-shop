using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace HardwareShopRole.Data
{
    public class HardwareShopUser : IdentityUser
    {
        public HardwareShopUser()
        {
            this.ComputerMapping = new HashSet<ComputerUserMapping>();
            this.ServicePackages = new HashSet<ServicePackage>();
        }

        public string FavouriteComputer { get; set; }

        public ICollection<ComputerUserMapping> ComputerMapping
        {
            get; set;
        }
        public ICollection<ServicePackage> ServicePackages
        {
            get; set;
        }
    }
}
