using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace InventoryManagement.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        public int Code { get; set; }

        [Display(Name = "Наименование на продукт")]
        [Required(ErrorMessage = "Полето е задължително")]
        [MaxLength(50, ErrorMessage = "Допустими символи 50")]
        public string ProductName { get; set; }

        [Display(Name = "Описание на продукт")]
        [MaxLength(2000, ErrorMessage = "Допустими символи 2000")]
        public string? Descripion { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Цена купува")]
        [Required(ErrorMessage = "Полето е задължително")]
        public decimal BidPrice { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Цена продава")]
        [Required(ErrorMessage = "Полето е задължително")]
        public decimal BuyoutPrice { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [Display(Name = "Количество")]
        public int ProductCount { get; set; }

        [MaxLength(50, ErrorMessage = "Допустими символи 50")]
        public string? ImageName { get; set; }

        [NotMapped]
        [Display(Name = "Картинка")]
        public IFormFile ImageFile { get; set; }

        //Connections between tables
        public Category Category { get; set; }
        public IdentityUser User { get; set; }
    }
}
