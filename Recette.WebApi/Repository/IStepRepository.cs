using Recette.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Repository
{
    public interface IStepRepository: IAsyncRepository<Step>
    {
        List<Step> GetByRecipeId(string recipeid);
    }
}
