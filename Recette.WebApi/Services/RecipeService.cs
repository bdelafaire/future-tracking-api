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
        IStepRepository _stepRepository;
        IIngredientRepository _ingredientRepository;

        public RecipeService (IAsyncRepository<Recipe> recipe, IStepRepository stepRepository, IIngredientRepository ingredientRepository)
        {
            _recipeRepo = recipe;
            _stepRepository = stepRepository;
            _ingredientRepository = ingredientRepository;
        }

        public async Task<Recipe> GetById(string id)
        {
            return await _recipeRepo.GetByIdAsync(id);
        }

        public async Task<IEnumerable<RecipeViewModel>> GetRecipes()
        {
            List<RecipeViewModel> recipes = new List<RecipeViewModel>();
            var result = await _recipeRepo.ListAllAsync();
            foreach (Recipe recipe in result)
            {
                RecipeViewModel recipeViewModel = new RecipeViewModel();
                recipeViewModel.Id = recipe.Id;
                recipeViewModel.Name = recipe.Name;
                recipeViewModel.NumberOfPersons = recipe.NumberOfPersons;
                var stepresult = _stepRepository.GetByRecipeId(recipe.Id);
                foreach (Step step in stepresult)
                {
                    StepViewModel localstep = new StepViewModel();
                    localstep.Id = step.Id;
                    localstep.Description = step.Description;
                    localstep.Number = step.Number;
                    recipeViewModel.Steps.Add(localstep);
                }

                var ingredientresult = _ingredientRepository.GetByRecipeId(recipe.Id);
                foreach ( Ingredient item in ingredientresult)
                {
                    IngredientViewModel localIngredient = new IngredientViewModel();
                    localIngredient.Id = item.Id;
                    localIngredient.Name = item.Name;
                    recipeViewModel.Ingredients.Add(localIngredient);
                }

                recipes.Add(recipeViewModel);
            }
            return recipes;
        }
    }
}
