using HardwareShop.Data.DataModels;
using System;

namespace HardwareShopRole.Data
{
    public class ServicePackage
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int MyProperty { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime DurationTime { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

    }
}