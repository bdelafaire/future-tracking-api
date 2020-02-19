using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Models.ViewModel
{
    public class StepViewModel
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
    }
}
