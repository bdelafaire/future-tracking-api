using Recette.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Services
{
    public interface IPdfGeneratorService
    {
        public string ToHtmlString(List<Recipe> recipes,string title);
        public void RecipeToPdf(List<Recipe> recipe);
    }
}
