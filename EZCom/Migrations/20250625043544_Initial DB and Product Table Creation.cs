using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EZCom.Migrations
{
    /// <inheritdoc />
    public partial class InitialDBandProductTableCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "High-performance laptop with 16GB RAM and 512GB SSD.", "laptop.jpg", "Laptop", 999.99m },
                    { 2, "Latest smartphone with 128GB storage and 12MP camera.", "smartphone.jpg", "Smartphone", 699.99m },
                    { 3, "Noise-cancelling over-ear headphones with Bluetooth connectivity.", "headphones.jpg", "Headphones", 199.99m },
                    { 4, "Stylish smartwatch with fitness tracking and heart rate monitor.", "smartwatch.jpg", "Smartwatch", 249.99m },
                    { 5, "10-inch tablet with high-resolution display and long battery life.", "tablet.jpg", "Tablet", 399.99m },
                    { 6, "Ergonomic wireless mouse with adjustable DPI settings.", "wireless_mouse.jpg", "Wireless Mouse", 49.99m },
                    { 7, "Portable Bluetooth speaker with deep bass and long battery life.", "bluetooth_speaker.jpg", "Bluetooth Speaker", 89.99m },
                    { 8, "1TB external hard drive for secure data storage.", "external_hard_drive.jpg", "External Hard Drive", 79.99m },
                    { 9, "Mechanical gaming keyboard with customizable RGB lighting.", "gaming_keyboard.jpg", "Gaming Keyboard", 129.99m },
                    { 10, "27-inch 4K monitor with ultra-thin bezels and HDR support.", "4k_monitor.jpg", "4K Monitor", 499.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
