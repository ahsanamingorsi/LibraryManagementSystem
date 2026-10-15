using LibraryManagement.Core.Enums;

namespace LibraryManagement.Core.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public ProductStatus Status { get; set; }
    }
}