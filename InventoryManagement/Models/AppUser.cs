using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace InventoryManagement.Models
{
    public class AppUser:IdentityUser
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
