using EZCom.Models;
using Microsoft.EntityFrameworkCore;

namespace EZCom.Services
{
    public class EZComDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public EZComDbContext(DbContextOptions<EZComDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "High-performance laptop with 16GB RAM and 512GB SSD.",
                    Price = 999.99m,
                    ImageFileName = "laptop.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Smartphone",
                    Description = "Latest smartphone with 128GB storage and 12MP camera.",
                    Price = 699.99m,
                    ImageFileName = "smartphone.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Description = "Noise-cancelling over-ear headphones with Bluetooth connectivity.",
                    Price = 199.99m,
                    ImageFileName = "headphones.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Smartwatch",
                    Description = "Stylish smartwatch with fitness tracking and heart rate monitor.",
                    Price = 249.99m,
                    ImageFileName = "smartwatch.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Tablet",
                    Description = "10-inch tablet with high-resolution display and long battery life.",
                    Price = 399.99m,
                    ImageFileName = "tablet.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Wireless Mouse",
                    Description = "Ergonomic wireless mouse with adjustable DPI settings.",
                    Price = 49.99m,
                    ImageFileName = "wireless_mouse.jpg"
                },
                new Product
                {
                    Id = 7,
                    Name = "Bluetooth Speaker",
                    Description = "Portable Bluetooth speaker with deep bass and long battery life.",
                    Price = 89.99m,
                    ImageFileName = "bluetooth_speaker.jpg"
                },
                new Product
                {
                    Id = 8,
                    Name = "External Hard Drive",
                    Description = "1TB external hard drive for secure data storage.",
                    Price = 79.99m,
                    ImageFileName = "external_hard_drive.jpg"
                },
                new Product
                {
                    Id = 9,
                    Name = "Gaming Keyboard",
                    Description = "Mechanical gaming keyboard with customizable RGB lighting.",
                    Price = 129.99m,
                    ImageFileName = "gaming_keyboard.jpg"
                },
                new Product
                {
                    Id = 10,
                    Name = "4K Monitor",
                    Description = "27-inch 4K monitor with ultra-thin bezels and HDR support.",
                    Price = 499.99m,
                    ImageFileName = "4k_monitor.jpg"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
