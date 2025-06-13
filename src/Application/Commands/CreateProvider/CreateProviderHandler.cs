using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstractions;
using Domain.Entities;
using MediatR;

namespace Application.Commands.CreateProvider;

public class CreateProviderHandler(IProviderRepository providerRepository) : IRequestHandler<CreateProviderCommand, Guid>
{
    public async Task<Guid> Handle(CreateProviderCommand command, CancellationToken ct)
    {
        var provider = new Provider(command.name, command.fyb, command.fye);
        await providerRepository.AddAsync(provider);
        return provider.Id;
    }
}