using Recette.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Repository
{
    public interface IIngredientRepository: IAsyncRepository<Ingredient>
    {
        List<Ingredient> GetByRecipeId(string recipeid);
    }
}
