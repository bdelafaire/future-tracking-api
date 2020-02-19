using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Models
{
    public class Recipe : IAggregateRoot
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int? NumberOfPersons { get; set; }
        public ICollection<IngredientRecipe> IngredientRecipes { get; set; }
        public ICollection<Step> Steps { get; set; }
        public string ImageBase64 { get; set; }

        public Recipe()
        {
            Steps = new List<Step>();
            IngredientRecipes = new List<IngredientRecipe>();
        }
    }
}
