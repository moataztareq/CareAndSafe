using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Management.Data.Migrations
{
    /// <inheritdoc />
    public partial class _44 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorite_AspNetUsers_UserId",
                table: "Favorite");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteNanny_Favorite_FavoritesId",
                table: "FavoriteNanny");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorite",
                table: "Favorite");

            migrationBuilder.DropIndex(
                name: "IX_Favorite_UserId",
                table: "Favorite");

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
                name: "Favorite",
                newName: "Favorites");

            migrationBuilder.AddColumn<int>(
                name: "NannyId",
                table: "Favorites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00074e80-1fda-4eca-ab0b-9cdca3d8af54", "3", "Nanny", "Nanny" },
                    { "2ed541ac-a495-42f0-9c6a-bf284f73cfab", "1", "Admin", "Admin" },
                    { "cc6aaa86-6283-4de5-98b3-ce9e74d65144", "4", "HR", "HR" },
                    { "e6da9779-a6ce-4492-b6c0-0bf3defd1ecb", "2", "User", "User" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteNanny_Favorites_FavoritesId",
                table: "FavoriteNanny",
                column: "FavoritesId",
                principalTable: "Favorites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_AspNetUsers_UserId",
                table: "Favorites",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteNanny_Favorites_FavoritesId",
                table: "FavoriteNanny");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_AspNetUsers_UserId",
                table: "Favorites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00074e80-1fda-4eca-ab0b-9cdca3d8af54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ed541ac-a495-42f0-9c6a-bf284f73cfab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc6aaa86-6283-4de5-98b3-ce9e74d65144");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6da9779-a6ce-4492-b6c0-0bf3defd1ecb");

            migrationBuilder.DropColumn(
                name: "NannyId",
                table: "Favorites");

            migrationBuilder.RenameTable(
                name: "Favorites",
                newName: "Favorite");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorite",
                table: "Favorite",
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

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_UserId",
                table: "Favorite",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorite_AspNetUsers_UserId",
                table: "Favorite",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteNanny_Favorite_FavoritesId",
                table: "FavoriteNanny",
                column: "FavoritesId",
                principalTable: "Favorite",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
