using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Babshibak.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display (Name ="Name of  Category")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}