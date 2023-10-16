using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFirstBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingEmps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { 101, 2, "Dusty", "piggy.jpg", true, "Shaw" },
                    { 111, 2, "Enoch", "Beaker.jpg", true, "Whitaker" },
                    { 121, 4, "Garion", "kermit.jpg", true, "Cox" },
                    { 131, 5, "Fozzie", "Fozzie_Bear.jpg", false, "Bear" },
                    { 141, 2, "Gonzo", "Gonzo.jpg", false, "The Great" },
                    { 151, 1, "Sam", "SameTheEagle.jpg", false, "The Eagle" },
                    { 171, 4, "Beaker", "Beaker.jpg", false, "The Muppet" },
                    { 181, 5, "Fozzie ", "Fozzie_Bear.jpg", false, "Bear 2" },
                    { 191, 2, "Gonzo", "Gonzo.jpg", false, "The Great 2" },
                    { 201, 1, "Sam", "SameTheEagle.jpg", false, "The Eagle 2" },
                    { 211, 4, "Fried", "Beaker.jpg", false, "Pickle ?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 211);

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
    }
}
