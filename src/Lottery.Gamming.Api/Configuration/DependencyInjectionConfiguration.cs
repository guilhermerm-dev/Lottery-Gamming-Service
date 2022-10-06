using Lottery.Gamming.Infra.CrossCutting.BootStraper;

namespace Lottery.Gamming.Api.Configuration;

public static class DependencyInjectionConfiguration
{
    public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
    {
        if (services is null) throw new ArgumentNullException(nameof(services));

        InjectorBootStrapper.RegisterContainerServices(services);
    }
}