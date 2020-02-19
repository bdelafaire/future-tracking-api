using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Models
{
    [NotMapped]
    public class PdfModel
    {
        public List<string> RecipesId { get; set; }
        public string Title { get; set; }
        public PdfModel()
        {
            RecipesId = new List<string>();
        }
    }
}
