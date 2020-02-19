using Microsoft.AspNetCore.Mvc;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Advanced;
using Recette.WebApi.Models;
using Recette.WebApi.Repository;
using Recette.WebApi.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Recette.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PdfGeneratorController : Controller
    {
        private IPdfGeneratorService _pdfGeneratorService;
        private IRecipeService _recipeSevice;
        IStepService _stepService;

        public PdfGeneratorController(IPdfGeneratorService pdfGeneratorService, IRecipeService service, IStepService step)
        {
            _pdfGeneratorService = pdfGeneratorService;
            _recipeSevice = service;
            _stepService = step;
        }
        
        [HttpPost]
        [Route("/api/topdf")]
        public async Task<ActionResult> DownloadPdf([FromBody]PdfModel pdf)
        {
            List<Recipe> recipes = new List<Recipe>();
            foreach (string recipe in pdf.RecipesId)
            {
                var result = await _recipeSevice.GetById(recipe);
                var resultStep = await _stepService.GetAll();
                result.Steps = resultStep.ToList();
                recipes.Add(result);
            }
            var toto = _pdfGeneratorService.ToHtmlString(recipes, pdf.Title);

            return Ok(toto);


            //MemoryStream memory = new MemoryStream();
            ////using (FileStream stream = new FileStream(@"C:\Users\baptiste\Downloads", FileMode.Open))
            ////{
            ////    await stream.CopyToAsync(memory);
            ////}

            //memory.Position = 0;

            //return File(memory, "application/force-download", "test.pdf");

        }

        [HttpGet("{id}")]
        public async Task<ActionResult> DownloadPdfRecipe(string id)
        {
            List<Recipe> recipes = new List<Recipe>();
            var resultRecipe = await _recipeSevice.GetById(id);

            var resultStep = await _stepService.GetAll();
            resultRecipe.Steps = resultStep.ToList();
            recipes.Add(resultRecipe);
            var html = _pdfGeneratorService.ToHtmlString(recipes, "toto");

            //return Ok(toto);

            MemoryStream memoryStream = new MemoryStream();
            TextWriter tw = new StreamWriter(memoryStream);

            tw.WriteLine(html);
            tw.Flush();
            tw.Close();

            return File(memoryStream.GetBuffer(), "text/plain", "file.html");

        }

    }
}
