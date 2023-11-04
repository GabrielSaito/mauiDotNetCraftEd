using CraftEd.Models;
using CraftEd.Repositories;
using LiteDB;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
namespace App_maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>().UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Syncopate-Regular", "Syncopate-Regular");
                fonts.AddFont("Syncopate-Bold.ttf", "Syncopate-Bold");
            }).RegistrarBancoDeDados();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
    public static MauiAppBuilder RegistrarBancoDeDados(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<LiteDatabase>(
            opcoes =>
            {
                return new LiteDatabase($"FileName ={AppSettings.BancoDeDadosDiretorio};Connection=Shared");
            }
            );
        builder.Services.AddTransient<IAulaRepositorio, AulaRepositorio>();
        return builder;
    }


}
