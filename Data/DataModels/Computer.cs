using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HardwareShopRole.Data
{
    public class Computer
    {
        public Computer()
        {
            this.UserMapping = new HashSet<ComputerUserMapping>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 2)]
        public string Model { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public string Brand { get; set; }

        public DateTime Year { get; set; }

        public string Description { get; set; }

        public ICollection <ComputerUserMapping> UserMapping { get; set; }
    }
}