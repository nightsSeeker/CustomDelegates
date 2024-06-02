using FGW.Core.Extensions;
using FGW.Core.Farm.Entities.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FGW.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddHostedService<FarmLaunch>();
        services.AddSubscribers<ISubscribe, FarmLaunch>();
        return services;
    }
}