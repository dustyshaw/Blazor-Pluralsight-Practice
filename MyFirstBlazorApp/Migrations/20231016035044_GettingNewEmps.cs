using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFirstBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class GettingNewEmps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "FirstName", "ImageUrl", "IsDeveloper", "LastName" },
                values: new object[,]
                {
                    { 10, 2, "Dusty", "piggy.jpg", true, "Shaw" },
                    { 11, 2, "Enoch", "Beaker.jpg", true, "Whitaker" },
                    { 12, 4, "Garion", "kermit.jpg", true, "Cox" },
                    { 13, 5, "Jack", "piggy.jpg", false, "Beans" },
                    { 14, 2, "Jill", "Beaker.jpg", false, "Hill" },
                    { 15, 1, "Jane", "piggy.jpg", false, "Doe" },
                    { 16, 4, "Joe", "Beaker.jpg", false, "Pickle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "FirstName", "ImageUrl", "IsDeveloper", "LastName" },
                values: new object[,]
                {
                    { 1, 2, "Dusty", "piggy.jpg", true, "Shaw" },
                    { 2, 2, "Enoch", "Beaker.jpg", true, "Whitaker" },
                    { 3, 4, "Garion", "kermit.jpg", true, "Cox" },
                    { 4, 5, "Jack", "piggy.jpg", false, "Beans" },
                    { 5, 2, "Jill", "Beaker.jpg", false, "Hill" },
                    { 6, 1, "Jane", "piggy.jpg", false, "Doe" },
                    { 7, 4, "Joe", "Beaker.jpg", false, "Pickle" }
                });
        }
    }
}
