﻿using Aeronave.Domain.Model.Aeronaves;
using SharedKernel.Core;

namespace Aeronave.Domain.Repositories
{
    public interface IAeronaveRepository : IRepository<AeronaveModel, Guid>
    {
        Task UpdateAsync(AeronaveModel obj);
        Task<List<AeronaveModel>> GetAllOperativeAeronaves();
    }
}