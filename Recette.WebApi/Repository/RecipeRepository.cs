using Recette.WebApi.Data;
using Recette.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Repository
{
    public class RecipeRepository : EfRepository<Recipe>
    {
        public RecipeRepository(AppDbContext appDbContext): base(appDbContext)
        {
            
        }

        public List<Recipe> GetRecipesById()
        {
            var result =  _appDbContext.Set<Recipe>().Where(r => r.Id == "toto");
            return result.ToList();
        }
    }
}
