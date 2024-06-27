using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Management.Data.Migrations
{
    /// <inheritdoc />
    public partial class init2222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Nanny_NannyId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryNanny_Category_CategoriesId",
                table: "CategoryNanny");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryNanny_Nanny_NanniesNannyId",
                table: "CategoryNanny");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteNanny_Nanny_NanniesNannyId",
                table: "FavoriteNanny");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Nanny_NannyId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nanny",
                table: "Nanny");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

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

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "Nanny",
                newName: "Nannies");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Review_UserId",
                table: "Reviews",
                newName: "IX_Reviews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_NannyId",
                table: "Reviews",
                newName: "IX_Reviews_NannyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ReviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nannies",
                table: "Nannies",
                column: "NannyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a42bf37-7628-409b-9139-29f4be964a72", "4", "HR", "HR" },
                    { "a96621a3-29e8-4710-9dfa-9eb7a912ec3d", "3", "Nanny", "Nanny" },
                    { "f70a18cd-a1bd-4569-b7bf-7f0728f1d42f", "1", "Admin", "Admin" },
                    { "f847c4c1-0820-4038-bd0e-c629e7a2d2fe", "2", "User", "User" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Nannies_NannyId",
                table: "Bookings",
                column: "NannyId",
                principalTable: "Nannies",
                principalColumn: "NannyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryNanny_Categories_CategoriesId",
                table: "CategoryNanny",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryNanny_Nannies_NanniesNannyId",
                table: "CategoryNanny",
                column: "NanniesNannyId",
                principalTable: "Nannies",
                principalColumn: "NannyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteNanny_Nannies_NanniesNannyId",
                table: "FavoriteNanny",
                column: "NanniesNannyId",
                principalTable: "Nannies",
                principalColumn: "NannyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Nannies_NannyId",
                table: "Reviews",
                column: "NannyId",
                principalTable: "Nannies",
                principalColumn: "NannyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Nannies_NannyId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryNanny_Categories_CategoriesId",
                table: "CategoryNanny");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryNanny_Nannies_NanniesNannyId",
                table: "CategoryNanny");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteNanny_Nannies_NanniesNannyId",
                table: "FavoriteNanny");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Nannies_NannyId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nannies",
                table: "Nannies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a42bf37-7628-409b-9139-29f4be964a72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a96621a3-29e8-4710-9dfa-9eb7a912ec3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f70a18cd-a1bd-4569-b7bf-7f0728f1d42f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f847c4c1-0820-4038-bd0e-c629e7a2d2fe");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "Nannies",
                newName: "Nanny");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserId",
                table: "Review",
                newName: "IX_Review_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_NannyId",
                table: "Review",
                newName: "IX_Review_NannyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ReviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nanny",
                table: "Nanny",
                column: "NannyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Nanny_NannyId",
                table: "Bookings",
                column: "NannyId",
                principalTable: "Nanny",
                principalColumn: "NannyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryNanny_Category_CategoriesId",
                table: "CategoryNanny",
                column: "CategoriesId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryNanny_Nanny_NanniesNannyId",
                table: "CategoryNanny",
                column: "NanniesNannyId",
                principalTable: "Nanny",
                principalColumn: "NannyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteNanny_Nanny_NanniesNannyId",
                table: "FavoriteNanny",
                column: "NanniesNannyId",
                principalTable: "Nanny",
                principalColumn: "NannyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Nanny_NannyId",
                table: "Review",
                column: "NannyId",
                principalTable: "Nanny",
                principalColumn: "NannyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
