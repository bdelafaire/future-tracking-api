using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Recette.WebApi.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Recette.WebApi.Data.Configuration
{
    public class IngredientRecipeConfiguration : IEntityTypeConfiguration<IngredientRecipe>
    {
        public void Configure(EntityTypeBuilder<IngredientRecipe> builder)
        {
            builder.HasKey(ir => new { ir.IngredientId, ir.RecipeId });
            builder
                .HasOne(ir => ir.Ingredient)
                .WithMany(i => i.IngredientRecipes)
                .HasForeignKey(ir => ir.IngredientId);
            builder
                .HasOne(ir => ir.Recipe)
                .WithMany(r => r.IngredientRecipes)
                .HasForeignKey(ir => ir.IngredientId);
        }
    }
}
