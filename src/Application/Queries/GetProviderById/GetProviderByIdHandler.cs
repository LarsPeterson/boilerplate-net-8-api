using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstractions;
using Domain.Entities;
using MediatR;

namespace Application.Queries.GetProviderById;

public class GetProviderByIdHandler(IProviderRepository providerRepository) : IRequestHandler<GetProviderByIdQuery, Provider>
{
    public async Task<Provider> Handle(GetProviderByIdQuery command, CancellationToken ct)
    {
        return await providerRepository.GetByIdAsync(command.Id);
    }
}