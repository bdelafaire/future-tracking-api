using Microsoft.EntityFrameworkCore.Migrations;

namespace Recette.WebApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NumberOfPersons = table.Column<int>(nullable: true),
                    ImageBase64 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientRecipe",
                columns: table => new
                {
                    IngredientId = table.Column<string>(nullable: false),
                    RecipeId = table.Column<string>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipe", x => new { x.IngredientId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Recipe_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Recipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    RecipeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "ImageBase64", "Name", "NumberOfPersons" },
                values: new object[] { "d3aaaff0-ad3d-403b-ae93-67964fb267c8", "", "Tarte aux pommes", 6 });

            migrationBuilder.InsertData(
                table: "Step",
                columns: new[] { "Id", "Description", "Number", "RecipeId" },
                values: new object[,]
                {
                    { "d3adaff0-ad3d-443b-ae93-67964fb267e1", "Éplucher et découper en morceaux 4 Golden.", 1, "d3aaaff0-ad3d-403b-ae93-67964fb267c8" },
                    { "d3adaff0-ad3d-443b-ae93-67964fb267e2", "Faire une compote : les mettre dans une casserole avec un peu d'eau (1 verre ou 2). Bien remuer. Quand les pommes commencent à ramollir, ajouter un sachet ou un sachet et demi de sucre vanillé. Ajouter un peu d'eau si nécessaire.", 2, "d3aaaff0-ad3d-403b-ae93-67964fb267c8" },
                    { "d3adaff0-ad3d-443b-ae93-67964fb267e4", "Vous saurez si la compote est prête une fois que les pommes ne seront plus dures du tout. Ce n'est pas grave s'il reste quelques morceaux.", 3, "d3aaaff0-ad3d-403b-ae93-67964fb267c8" },
                    { "d3adaff0-ad3d-443b-ae93-67964fb267e3", "Pendant que la compote cuit, éplucher et couper en quatre les deux dernières pommes, puis, couper les quartiers en fines lamelles (elles serviront à être posées sur la compote).", 4, "d3aaaff0-ad3d-403b-ae93-67964fb267c8" },
                    { "d3adaff0-ad3d-443b-ae93-67964fb267e5", "Préchauffer le four à 210°C (thermostat 7).", 5, "d3aaaff0-ad3d-403b-ae93-67964fb267c8" },
                    { "d3adaff0-ad3d-443b-ae93-67964fb267e6", "Laisser un peu refroidir la compote et étaler la pâte brisée dans un moule et la piquer avec une fourchette.", 6, "d3aaaff0-ad3d-403b-ae93-67964fb267c8" },
                    { "d3adaff0-ad3d-443b-ae93-67964fb267e7", "Verser la compote sur la pâte et placer les lamelles de pommes en formant une spirale ou plusieurs cercles, au choix ! Disposer des lamelles de beurre dessus.", 7, "d3aaaff0-ad3d-403b-ae93-67964fb267c8" },
                    { "d3adaff0-ad3d-443b-ae93-67964fb267e8", "Mettre au four et laisser cuire pendant 30 min max. Surveiller la cuisson. Vous pouvez ajouter un peu de sucre vanillé sur la tarte pendant que çà cuit pour caraméliser un peu.", 8, "d3aaaff0-ad3d-403b-ae93-67964fb267c8" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Step_RecipeId",
                table: "Step",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecipe");

            migrationBuilder.DropTable(
                name: "Step");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
