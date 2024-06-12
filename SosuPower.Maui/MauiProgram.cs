using Microsoft.Extensions.Logging;
using SosuPower.Maui.viewmodels;
using SosuPower.Maui.Views;
using SosuPower.Services;

namespace SosuPower.Maui
{
    public static class MauiProgram
    {
        private const string Url = "https://10.0.2.2:7238/api/";
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

            Uri baseUri = new Uri(Url);
            builder.Services.AddScoped<ISosuService>(x => new TaskService(baseUri));
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
