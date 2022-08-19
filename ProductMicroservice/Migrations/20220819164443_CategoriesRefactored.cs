using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductMicroservice.Migrations
{
    public partial class CategoriesRefactored : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Clothing Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Dresses");
        }
    }
}
