using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Recette.WebApi.Models;
using Recette.WebApi.Models.ViewModel;
using Recette.WebApi.Services;

public class PdfGeneratorService : IPdfGeneratorService
{
    public void RecipeToPdf(List<Recipe> recipe)
    {
        throw new NotImplementedException();
    }

    public string ToHtmlString(List<RecipeViewModel> recipes, string title)
    {
        //var toto = recipes.Aggregate("<html><body>", (html, recipe) => {
        //    string ingredientsHtml = recipe.IngredientRecipes.Aggregate("", (irHtml, ir) => {
        //        return $"{irHtml} {ir.Ingredient.Name} {ir.Quantity}<br />";
        //    });

        //var toto = recipes.Aggregate("<html><body>", (html, recipe) => {
        //    return $"{html} {recipe.Id} {recipe.Name}<br />";
        //}).Concat("</body></html>");

        StringBuilder sb = new StringBuilder("<html><body><br>");
        sb.Append($"<h1>{title}</h1>");
        foreach (RecipeViewModel recipe in recipes)
        {
            sb.Append($"<h1>Ingredient</h1>");
            sb.Append("<ul>");
            foreach (IngredientViewModel ingredient in recipe.Ingredients)
            {
                sb.Append($"<li>{ingredient.Name}</li>");
            }
            sb.Append("</ul>");
            sb.Append($"<h1>Etape</h1>");
            sb.Append("<ul>");
            foreach (StepViewModel step in recipe.Steps)
            {
                sb.Append($"<li>Etape n°{step.Number}: {step.Description}</li>");
            }
            sb.Append("</ul>");
        }
        sb.Append("</body></html>");

        return sb.ToString();
    }
}