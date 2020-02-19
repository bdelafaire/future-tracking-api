using Recette.WebApi.Data;
using Recette.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Repository
{
    public class IngredientRepository : EfRepository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public List<Ingredient> GetByRecipeId(string recipeid)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            var result = _appDbContext.Set<IngredientRecipe>().Where(ir => ir.RecipeId == recipeid).ToList();
            foreach (IngredientRecipe item in result)
            {
                var ingredient = _appDbContext.Set<Ingredient>().First(i => i.Id == item.IngredientId);
                ingredients.Add(ingredient);
            }
            return ingredients;
        }
    }
}
