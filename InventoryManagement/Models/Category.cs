using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace InventoryManagement.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [MaxLength(50, ErrorMessage = "Допустими символи 50")]
        [Display(Name = "Категория")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }

        public IdentityUser User { get; set; }
    }
}
