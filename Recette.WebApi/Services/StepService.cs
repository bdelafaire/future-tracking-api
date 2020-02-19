using Recette.WebApi.Models;
using Recette.WebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recette.WebApi.Services
{
    public class StepService : IStepService
    {
        IAsyncRepository<Step> _repo;

        public StepService(IAsyncRepository<Step> repo)
        {
            _repo = repo;
        }

        public async Task<IReadOnlyList<Step>> GetAll()
        {
            return await _repo.ListAllAsync();
        }

        public async Task<Step> GetById(string id)
        {
            return await _repo.GetByIdAsync(id);
        }
    }
}
