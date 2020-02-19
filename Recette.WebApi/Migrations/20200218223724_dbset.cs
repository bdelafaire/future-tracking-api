using Microsoft.EntityFrameworkCore.Migrations;

namespace Recette.WebApi.Migrations
{
    public partial class dbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "IngredientRecipe",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "d3aaaff0-ad3d-403b-ae93-67964fb267e8", "pomme" },
                    { "d3adaff0-ad3d-403b-ae93-67964fb267e8", "pâte brisée" },
                    { "d3adaff0-ad3d-403b-af93-67964fb267e8", "sachet de sucre vanillé" },
                    { "d3adaff0-ad3d-403b-ae93-67964fb267e9", "sucre" }
                });

            migrationBuilder.InsertData(
                table: "IngredientRecipe",
                columns: new[] { "IngredientId", "RecipeId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { "d3aaaff0-ad3d-403b-ae93-67964fb267e8", "d3aaaff0-ad3d-403b-ae93-67964fb267c8", 6, "unit" },
                    { "d3adaff0-ad3d-403b-ae93-67964fb267e8", "d3aaaff0-ad3d-403b-ae93-67964fb267c8", 1, "unit" },
                    { "d3adaff0-ad3d-403b-af93-67964fb267e8", "d3aaaff0-ad3d-403b-ae93-67964fb267c8", 1, "unit" },
                    { "d3adaff0-ad3d-403b-ae93-67964fb267e9", "d3aaaff0-ad3d-403b-ae93-67964fb267c8", 30, "gramme" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientRecipe",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { "d3aaaff0-ad3d-403b-ae93-67964fb267e8", "d3aaaff0-ad3d-403b-ae93-67964fb267c8" });

            migrationBuilder.DeleteData(
                table: "IngredientRecipe",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { "d3adaff0-ad3d-403b-ae93-67964fb267e8", "d3aaaff0-ad3d-403b-ae93-67964fb267c8" });

            migrationBuilder.DeleteData(
                table: "IngredientRecipe",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { "d3adaff0-ad3d-403b-ae93-67964fb267e9", "d3aaaff0-ad3d-403b-ae93-67964fb267c8" });

            migrationBuilder.DeleteData(
                table: "IngredientRecipe",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { "d3adaff0-ad3d-403b-af93-67964fb267e8", "d3aaaff0-ad3d-403b-ae93-67964fb267c8" });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: "d3aaaff0-ad3d-403b-ae93-67964fb267e8");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: "d3adaff0-ad3d-403b-ae93-67964fb267e8");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: "d3adaff0-ad3d-403b-ae93-67964fb267e9");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: "d3adaff0-ad3d-403b-af93-67964fb267e8");

            migrationBuilder.AlterColumn<string>(
                name: "Quantity",
                table: "IngredientRecipe",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
