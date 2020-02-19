using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Models
{
    public class Step : IAggregateRoot
    {
        public string Id { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public Recipe Recipe { get; set; }
        public string RecipeId { get; set; }
    }
}
