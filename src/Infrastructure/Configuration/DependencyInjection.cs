using Application.Abstractions;
using Infrastructure.Services;
using Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IProviderRepository, ProviderRepository>();
        services.AddScoped<IEmailService, EmailService>();

        return services;
    }
}
