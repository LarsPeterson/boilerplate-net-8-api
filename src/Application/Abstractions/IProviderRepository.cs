using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Abstractions
{
    public interface IProviderRepository
    {
        Task AddAsync(Provider provider);
        Task<Provider> GetByIdAsync(Guid id);
        Task GetAsync(List<Guid> id);
    }
}