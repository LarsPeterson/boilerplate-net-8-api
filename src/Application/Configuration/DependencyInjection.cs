using Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Application.Commands.CreateProvider;
using MediatR;

namespace Application.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(GetProviderHandler).Assembly);

        // Optionally register other Application-level things:
        // - Behaviors (logging, validation, transactions)
        // - Validators
        // - Mapping profiles (AutoMapper if used)
        // - Domain event handlers

        return services;
    }
}
