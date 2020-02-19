using Recette.WebApi.Models;
using Recette.WebApi.Models.ViewModel;
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

        public async Task<IReadOnlyList<RecipeViewModel>> GetRecipes()
        {
            List<RecipeViewModel> recipes = new List<RecipeViewModel>();
            var result = await _recipeRepo.ListAllAsync();
            foreach (Recipe recipe in result)
            {
                RecipeViewModel recipeViewModel = new RecipeViewModel();
                recipeViewModel.Id = recipe.Id;
                recipeViewModel.Name = recipe.Name;
                recipeViewModel.NumberOfPersons = recipe.NumberOfPersons;
                
            }
            return new List<RecipeViewModel>();
        }
    }
}
