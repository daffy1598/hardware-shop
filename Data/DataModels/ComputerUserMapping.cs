using HardwareShop.Data.DataModels;

namespace HardwareShopRole.Data
{
    public class ComputerUserMapping
    {
        public string UserId { get; set; }

        public User User { get; set; }
        
        public int ComputerId { get; set; }

        public Computer Computer { get; set; }

    }
}