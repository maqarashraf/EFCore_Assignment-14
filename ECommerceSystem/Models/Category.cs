using System.Collections.Generic;

namespace ECommerceSystem.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation Property (One-to-Many with Product)
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}