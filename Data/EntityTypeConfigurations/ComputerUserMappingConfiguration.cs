using HardwareShopRole.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareShop.Data.EntityTypeConfigurations
{
    public class ComputerUserMappingConfiguration : IEntityTypeConfiguration<ComputerUserMapping>
    {
        public void Configure(EntityTypeBuilder<ComputerUserMapping> builder)
        {
            builder.HasKey(cum => new { cum.ComputerId, cum.UserId});

            builder.HasOne(cum => cum.Computer)
                .WithMany(c => c.UserMapping)
                .HasForeignKey(cum => cum.ComputerId);

            builder.HasOne(cum => cum.User)
                .WithMany(u => u.ComputersMapping)
                .HasForeignKey(cum => cum.UserId);

          

        }
    }
}
