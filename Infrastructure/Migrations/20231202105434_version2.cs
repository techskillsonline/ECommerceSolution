using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class version2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryDescription", "CategoryName", "Createdby", "ParentCategoryId", "UpdatedBy", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "Electronics Category", "Electronics", "rahulsinghishere@gmail.com", null, null, null },
                    { 2, "Shoes Category", "Shoes", "rahulsinghishere@gmail.com", null, null, null },
                    { 3, "Cosmetics Category", "Cosmetics", "rahulsinghishere@gmail.com", null, null, null },
                    { 4, "Clothing Category", "Clothing", "rahulsinghishere@gmail.com", null, null, null },
                    { 5, "Laptops Category", "Laptops", "rahulsinghishere@gmail.com", 1, null, null },
                    { 6, "Mobiles Category", "Mobiles", "rahulsinghishere@gmail.com", 1, null, null },
                    { 7, "Tablets Category", "Tablets", "rahulsinghishere@gmail.com", 1, null, null },
                    { 8, "Running Shoes Category", "Running Shoes", "rahulsinghishere@gmail.com", 2, null, null },
                    { 9, "Boots Category", "Boots", "rahulsinghishere@gmail.com", 2, null, null },
                    { 10, "Formal Shoes Category", "Formal Shoes", "rahulsinghishere@gmail.com", 2, null, null },
                    { 11, "Casual Shoes Category", "Casual Shoes", "rahulsinghishere@gmail.com", 4, null, null },
                    { 12, "WinterWear Category", "WinterWear", "rahulsinghishere@gmail.com", 4, null, null },
                    { 13, "SummerWear Category", "SummerWear", "rahulsinghishere@gmail.com", 4, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
