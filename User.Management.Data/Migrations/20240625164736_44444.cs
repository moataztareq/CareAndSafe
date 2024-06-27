using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User.Management.Data.Migrations
{
    /// <inheritdoc />
    public partial class _44444 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteNanny");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d16063b-9c37-4bf9-80e9-280b3a8eb349");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a09e76c-b666-4cbe-a425-30dd2ee6e788");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae35e1be-1f7c-4dae-bd1f-a19b2a3d3f50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9613482-4851-435f-8cd8-7b958137ee36");

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
                name: "IX_Favorites_NannyId",
                table: "Favorites",
                column: "NannyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Nannies_NannyId",
                table: "Favorites",
                column: "NannyId",
                principalTable: "Nannies",
                principalColumn: "NannyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Nannies_NannyId",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_NannyId",
                table: "Favorites");

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

            migrationBuilder.CreateTable(
                name: "FavoriteNanny",
                columns: table => new
                {
                    FavoritesId = table.Column<int>(type: "int", nullable: false),
                    NanniesNannyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteNanny", x => new { x.FavoritesId, x.NanniesNannyId });
                    table.ForeignKey(
                        name: "FK_FavoriteNanny_Favorites_FavoritesId",
                        column: x => x.FavoritesId,
                        principalTable: "Favorites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteNanny_Nannies_NanniesNannyId",
                        column: x => x.NanniesNannyId,
                        principalTable: "Nannies",
                        principalColumn: "NannyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d16063b-9c37-4bf9-80e9-280b3a8eb349", "1", "Admin", "Admin" },
                    { "4a09e76c-b666-4cbe-a425-30dd2ee6e788", "3", "Nanny", "Nanny" },
                    { "ae35e1be-1f7c-4dae-bd1f-a19b2a3d3f50", "4", "HR", "HR" },
                    { "c9613482-4851-435f-8cd8-7b958137ee36", "2", "User", "User" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteNanny_NanniesNannyId",
                table: "FavoriteNanny",
                column: "NanniesNannyId");
        }
    }
}
