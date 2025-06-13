using Application.Abstractions;
using Infrastructure.Services;
using Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection AddApi(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        return services;
    }
}
