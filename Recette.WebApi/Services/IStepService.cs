using Recette.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Services
{
    public interface IStepService
    {
        Task<IReadOnlyList<Step>> GetAll();
    }
}
