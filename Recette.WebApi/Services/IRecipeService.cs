using Recette.WebApi.Models;
using Recette.WebApi.Models.ViewModel;
using Recette.WebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Services
{
    public interface IRecipeService
    {
        Task<Recipe> GetById(string id);
        Task<IEnumerable<RecipeViewModel>> GetRecipes();

    }
}
