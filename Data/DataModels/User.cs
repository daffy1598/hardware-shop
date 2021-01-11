using HardwareShopRole.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareShop.Data.DataModels
{
    public class User : IdentityUser
    {
        public User()
        {
            this.ComputersMapping = new HashSet<ComputerUserMapping>();
            this.ServicePackages = new HashSet<ServicePackage>();
        }
    
      
            
        

        public ICollection<ComputerUserMapping> ComputersMapping { get; set; }
        public ICollection<ServicePackage> ServicePackages { get; set; }
    }
}
