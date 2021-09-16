using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test1.Models
{
    public class Category
    {
        [Required, MaxLength(50)]
        public string CategoryName { get; set; }
        [Required]
        public int Order { get; set; }
        public string Notes { get; set; }

        public ICollection<Flower> Flowers { get; set; }
    }
}