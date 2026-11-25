using System.Collections.Generic;

namespace ECommerceSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Navigation Property (One-to-Many with Order)
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}