using HardwareShopRole.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareShop.Data.EntityTypeConfigurations
{
    public class ServicePackageConfiguration : IEntityTypeConfiguration<ServicePackage>
    {
        public void Configure(EntityTypeBuilder<ServicePackage> builder)
        {
            builder.HasOne(sp => sp.User)
                 .WithMany(u => u.ServicePackages)
                 .HasForeignKey(sp => sp.UserId)
                 .OnDelete(DeleteBehavior.NoAction);

            builder.Property(sp => sp.Price)
                .HasColumnType("DECIMAL(15, 2)");
           
        }
    }
}
