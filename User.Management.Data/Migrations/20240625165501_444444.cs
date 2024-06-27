using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Management.Data.Migrations
{
    /// <inheritdoc />
    public partial class _444444 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_NannyId",
                table: "Bookings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1003e137-705a-41d8-95e9-77b93d266785");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "470fb303-49ab-40b5-a479-fc58abfea857");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "785a6c43-38d0-4928-bd49-13e5fc86e7d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a97929fa-fd30-4411-8138-8d2c44306c1a");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61064300-b983-4a43-baf5-29277e5283dc", "2", "User", "User" },
                    { "aa8646e3-d677-474b-92ad-ac68c7021ef7", "1", "Admin", "Admin" },
                    { "aac34f0e-de81-4215-bad1-aa03800002d7", "3", "Nanny", "Nanny" },
                    { "d752a584-d50e-4cc4-ad9e-d39a0bf8d3dd", "4", "HR", "HR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_NannyId",
                table: "Bookings",
                column: "NannyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_NannyId",
                table: "Bookings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61064300-b983-4a43-baf5-29277e5283dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa8646e3-d677-474b-92ad-ac68c7021ef7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aac34f0e-de81-4215-bad1-aa03800002d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d752a584-d50e-4cc4-ad9e-d39a0bf8d3dd");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1003e137-705a-41d8-95e9-77b93d266785", "2", "User", "User" },
                    { "470fb303-49ab-40b5-a479-fc58abfea857", "3", "Nanny", "Nanny" },
                    { "785a6c43-38d0-4928-bd49-13e5fc86e7d9", "1", "Admin", "Admin" },
                    { "a97929fa-fd30-4411-8138-8d2c44306c1a", "4", "HR", "HR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_NannyId",
                table: "Bookings",
                column: "NannyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
