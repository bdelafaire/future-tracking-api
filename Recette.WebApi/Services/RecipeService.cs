using Recette.WebApi.Models;
using Recette.WebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Services
{
    public class RecipeService : IRecipeService
    {
        IAsyncRepository<Recipe> _recipeRepo;

        public RecipeService (IAsyncRepository<Recipe> recipe)
        {
            _recipeRepo = recipe;
        }

        public async Task<Recipe> GetById(string id)
        {
            return await _recipeRepo.GetByIdAsync(id);
        }

        public async Task<IReadOnlyList<Recipe>> GetRecipes()
        {
            return await _recipeRepo.ListAllAsync();
        }
    }
}
