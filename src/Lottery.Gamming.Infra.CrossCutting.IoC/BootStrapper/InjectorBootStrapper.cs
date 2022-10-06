using Lottery.Gamming.Domain.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Lottery.Gamming.Infra.CrossCutting.BootStraper;

public static class InjectorBootStrapper
{
    public static void RegisterContainerServices(IServiceCollection services)
    {
        services.AddTransient<IDrawLotoFacilGames, DrawLotoFacilGames>();
        services.AddTransient<IDrawMegaSenaGames, DrawMegaSenaGames>();
    }
}