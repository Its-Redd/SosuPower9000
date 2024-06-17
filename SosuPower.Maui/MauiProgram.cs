using Microsoft.Extensions.Logging;
using SosuPower.Maui.viewmodels;
using SosuPower.Maui.views;
using SosuPower.Maui.Views;
using SosuPower.Services;

namespace SosuPower.Maui
{
    public static class MauiProgram
    {
        // The URL of the API. This is the IP address of the host machine running the API.
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
            // User service fik aldrig base uri med det du havde commited her.
            builder.Services.AddSingleton<IUserService>(x => new UserService(baseUri));
            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<LoginPageViewModel>();
            builder.Services.AddSingleton<LoginPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
