using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Management.Data.Migrations
{
    /// <inheritdoc />
    public partial class init22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ac905fa-bd90-4237-af8f-f56a2e2606aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68bc64d3-d4b6-418f-80ca-c5c347ba8895");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90b7856e-0933-4c7a-8e79-a5cacb4fd5dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "deb3f414-e017-421c-97e7-ecdab5abaa08");

            migrationBuilder.DropColumn(
                name: "ProofOfAddressImagePath",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "SSIDImagePath",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "SelfieWithYourIDImagePath",
                table: "Forms");

            migrationBuilder.AlterColumn<int>(
                name: "HourlyRateInPound",
                table: "Forms",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "HourlyRateInPound",
                table: "Forms",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ProofOfAddressImagePath",
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
                name: "SelfieWithYourIDImagePath",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ac905fa-bd90-4237-af8f-f56a2e2606aa", "3", "Nanny", "Nanny" },
                    { "68bc64d3-d4b6-418f-80ca-c5c347ba8895", "1", "Admin", "Admin" },
                    { "90b7856e-0933-4c7a-8e79-a5cacb4fd5dd", "4", "HR", "HR" },
                    { "deb3f414-e017-421c-97e7-ecdab5abaa08", "2", "User", "User" }
                });
        }
    }
}
