using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Models
{
    public class Ingredient : IAggregateRoot
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<IngredientRecipe> IngredientRecipes { get; set; }
    }
}
