using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Babshibak.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Discription")]
        public string Discription { get; set; }
        [Required]
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Required]
        
        public string Image { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}