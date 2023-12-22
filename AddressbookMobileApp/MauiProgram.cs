using AddressbookMobileApp.ViewModels;
using AppLibrary.Interfaces;
using AppLibrary.Services;
using Microsoft.Extensions.Logging;

namespace AddressbookMobileApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<IFileService, FileService>();
            builder.Services.AddSingleton<IContactService, ContactService>();

            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();



            builder.Logging.AddDebug();
            return builder.Build();
        }
    }
}
