using Application.Configuration;
using Infrastructure.Configuration;

namespace Api.Configuration;

public static class WebApplicationExtensions
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddApi();
        builder.Services.AddApplication();
        builder.Services.AddInfrastructure();
    }

    public static void ConfigurePipeline(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
    }
}