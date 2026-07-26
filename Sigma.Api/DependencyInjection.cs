using Sigma.Application;
using Sigma.Infrastructure;

namespace Sigma.Api;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApiDI(this IServiceCollection services)
    {
        services.AddApplicationDI().AddInfrastructureDI();
        return services;
    }
}