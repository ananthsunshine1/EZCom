using Microsoft.EntityFrameworkCore;

namespace EZCom.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Precision(18,2)]
        public decimal Price { get; set; }
        public string ImageFileName { get; set; } = string.Empty;
    }
}
