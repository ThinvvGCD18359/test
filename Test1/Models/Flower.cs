using System;
using System.ComponentModel.DataAnnotations;

namespace Test1.Models
{
    public class Flower
    {
        [Required, MaxLength(255)]
        public string FlowerName { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public DateTime StoreDate{ get; set; }
        [Required]
        public int StoreInventory { get; set; }

        public Category Categories{ get; set; }
    }
}