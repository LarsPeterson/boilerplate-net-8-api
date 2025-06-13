using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstractions;
using Domain.Entities;
using MediatR;

namespace Infrastructure.Data.Repositories;

public class ProviderRepository(AppDbContext context, IMediator mediator) : IProviderRepository
{
    public async Task AddAsync(Provider provider)
    {
        await context.Providers.AddAsync(provider);
        await context.SaveChangesAsync();

        foreach (var domainEvent in provider.DomainEvents)
        {
            await mediator.Publish(domainEvent);
        }
    }
}
