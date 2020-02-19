using Recette.WebApi.Data;
using Recette.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Repository
{
    public class StepRepository : EfRepository<Step>, IStepRepository
    {
        public StepRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public List<Step> GetByRecipeId(string recipeid)
        {
            var result = _appDbContext.Set<Step>().Where(s => s.RecipeId == recipeid);
            return result.ToList();
        }
    }
}
