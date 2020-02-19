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
        public List<IngredientViewModel> Ingredients { get; set; }
        public List<StepViewModel> Steps { get; set; }

        public RecipeViewModel()
        {
            Ingredients = new List<IngredientViewModel>();
            Steps = new List<StepViewModel>();
        }
    }
}
