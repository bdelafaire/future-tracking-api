using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Recette.WebApi.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Controllers
{
    public class RecipeController : Controller
    {
        IRecipeService _recipeService;
        
        public RecipeController(IRecipeService recipe)
        {
            _recipeService = recipe;
            
        }

        [HttpGet("/recipes")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _recipeService.GetRecipes();
            return Ok(result);
        }

    }
}
