using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Models.ViewModel
{
    public class RecipeViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPersons { get; set; }
        public List<IngredientViewModel> ingredientViewModels { get; set; }
        public List<StepViewModel> stepViewModels { get; set; }

        public RecipeViewModel()
        {
            ingredientViewModels = new List<IngredientViewModel>();
            stepViewModels = new List<StepViewModel>();
        }
    }
}
