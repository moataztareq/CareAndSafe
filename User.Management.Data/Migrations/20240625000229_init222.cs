using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Management.Data.Migrations
{
    /// <inheritdoc />
    public partial class init222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30f5d760-0674-40ab-a8a1-4c4871830f49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a17c073-19c1-47d6-be40-99513865aa28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66878583-08d6-4165-be70-b29e3baec8f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f54c804f-3ee7-405d-a04f-b15f8c975059");

            migrationBuilder.AddColumn<string>(
                name: "ProofOfAddressPath",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SSIDImagePath",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SelfieWithYourIDPath",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5594ce1f-28e0-454a-a3eb-e97b6b40e56b", "1", "Admin", "Admin" },
                    { "6ce9a3e3-978d-43fe-a9d1-1c1ae2f19274", "2", "User", "User" },
                    { "80264350-a46e-4050-9e11-5bfe0fa99094", "4", "HR", "HR" },
                    { "da9e1492-096b-4f48-907a-1c8533ad7e2b", "3", "Nanny", "Nanny" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5594ce1f-28e0-454a-a3eb-e97b6b40e56b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ce9a3e3-978d-43fe-a9d1-1c1ae2f19274");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80264350-a46e-4050-9e11-5bfe0fa99094");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da9e1492-096b-4f48-907a-1c8533ad7e2b");

            migrationBuilder.DropColumn(
                name: "ProofOfAddressPath",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "SSIDImagePath",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "SelfieWithYourIDPath",
                table: "Forms");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "30f5d760-0674-40ab-a8a1-4c4871830f49", "3", "Nanny", "Nanny" },
                    { "4a17c073-19c1-47d6-be40-99513865aa28", "4", "HR", "HR" },
                    { "66878583-08d6-4165-be70-b29e3baec8f1", "2", "User", "User" },
                    { "f54c804f-3ee7-405d-a04f-b15f8c975059", "1", "Admin", "Admin" }
                });
        }
    }
}
