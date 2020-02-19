using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Models
{
    public class IngredientRecipe : IAggregateRoot
    {
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public Ingredient Ingredient { get; set; }
        public string IngredientId { get; set; }
        public Recipe Recipe { get; set; }
        public string RecipeId { get; set; }
    }
}
