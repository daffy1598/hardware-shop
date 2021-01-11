
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardwareShopRole.Data
{
    public class ApplicationDbContext : IdentityDbContext<HardwareShopUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Computer> Computers { get; set; }

        public DbSet<ComputerUserMapping> ComputersUsersMapping { get; set; }

        public DbSet<ServicePackage> ServicePackages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }

}
