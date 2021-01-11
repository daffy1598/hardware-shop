

using System.Collections.Generic;

namespace HardwareShopRole.Data
{
    public class ComputerUserMapping
    {
        public string UserId { get; set; }

        public HardwareShopUser User { get; set; }

        public int ComputerId { get; set; }

        public Computer Computer { get; set; }

    }
}