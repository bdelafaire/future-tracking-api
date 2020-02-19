using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Recette.WebApi.Models;

namespace Recette.WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            Recipe recipe = new Recipe()
            {
                Id = "d3aaaff0-ad3d-403b-ae93-67964fb267c8",
                ImageBase64 = "",
                Name = "Tarte aux pommes",
                NumberOfPersons = 6,
            };

            builder.Entity<Recipe>().HasData(recipe);

            builder.Entity<Step>().HasData(
            new Step()
            {
                Id = "d3adaff0-ad3d-443b-ae93-67964fb267e1",
                Number = 1,
                Description = "Éplucher et découper en morceaux 4 Golden.",
                RecipeId = recipe.Id,
            },
            new Step()
            {
                Id = "d3adaff0-ad3d-443b-ae93-67964fb267e2",
                Number = 2,
                Description = "Faire une compote : les mettre dans une casserole avec un peu d\'eau (1 verre ou 2). Bien remuer. Quand les pommes commencent à ramollir, ajouter un sachet ou un sachet et demi de sucre vanillé. Ajouter un peu d\'eau si nécessaire.",
                RecipeId = recipe.Id,
            }, 
            new Step()
            {
                Id = "d3adaff0-ad3d-443b-ae93-67964fb267e4",
                Number = 3,
                Description = "Vous saurez si la compote est prête une fois que les pommes ne seront plus dures du tout. Ce n\'est pas grave s\'il reste quelques morceaux.",
                RecipeId = recipe.Id,
            },
            new Step()
            {
                Id = "d3adaff0-ad3d-443b-ae93-67964fb267e3",
                Number = 4,
                Description = "Pendant que la compote cuit, éplucher et couper en quatre les deux dernières pommes, puis, couper les quartiers en fines lamelles (elles serviront à être posées sur la compote).",
                RecipeId = recipe.Id,
            }, 
            new Step()
            {
                Id = "d3adaff0-ad3d-443b-ae93-67964fb267e5",
                Number = 5,
                Description = "Préchauffer le four à 210°C (thermostat 7).",
                RecipeId = recipe.Id,
            }, 
            new Step()
            {
                Id = "d3adaff0-ad3d-443b-ae93-67964fb267e6",
                Number = 6,
                Description = "Laisser un peu refroidir la compote et étaler la pâte brisée dans un moule et la piquer avec une fourchette.",
                RecipeId = recipe.Id,
            }, 
            new Step()
            {
                Id = "d3adaff0-ad3d-443b-ae93-67964fb267e7",
                Number = 7,
                Description = "Verser la compote sur la pâte et placer les lamelles de pommes en formant une spirale ou plusieurs cercles, au choix ! Disposer des lamelles de beurre dessus.",
                RecipeId = recipe.Id,
            },
            new Step()
            {
                Id = "d3adaff0-ad3d-443b-ae93-67964fb267e8",
                Number = 8,
                Description = "Mettre au four et laisser cuire pendant 30 min max. Surveiller la cuisson. Vous pouvez ajouter un peu de sucre vanillé sur la tarte pendant que çà cuit pour caraméliser un peu.",
                RecipeId = recipe.Id,
            });

            builder.Entity<Ingredient>().HasData(
                new Ingredient()
                {
                    Id= "d3aaaff0-ad3d-403b-ae93-67964fb267e8",
                    Name = "pomme"
                }, new Ingredient()
                {
                    Id = "d3adaff0-ad3d-403b-ae93-67964fb267e8",
                    Name = "pâte brisée"
                }, new Ingredient()
                {
                    Id = "d3adaff0-ad3d-403b-af93-67964fb267e8",
                    Name = "sachet de sucre vanillé"
                }, new Ingredient()
                {
                    Id = "d3adaff0-ad3d-403b-ae93-67964fb267e9",
                    Name = "sucre"
                });

            builder.Entity<IngredientRecipe>().HasData(
                new IngredientRecipe()
                {
                    IngredientId = "d3aaaff0-ad3d-403b-ae93-67964fb267e8",
                    RecipeId = recipe.Id,
                    Quantity = 6,
                    Unit = "unit"
                }, new IngredientRecipe()
                {
                    IngredientId = "d3adaff0-ad3d-403b-ae93-67964fb267e8",
                    RecipeId = recipe.Id,
                    Quantity = 1,
                    Unit = "unit"
                }, new IngredientRecipe()
                {
                    IngredientId = "d3adaff0-ad3d-403b-af93-67964fb267e8",
                    RecipeId = recipe.Id,
                    Quantity = 1,
                    Unit = "unit"
                }, new IngredientRecipe()
                {
                    IngredientId = "d3adaff0-ad3d-403b-ae93-67964fb267e9",
                    RecipeId = recipe.Id,
                    Quantity = 30,
                    Unit = "gramme"
                });

        }
    }
}
