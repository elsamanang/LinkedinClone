using CommunityToolkit.Maui;
using LinkedinClone.Handlers;
using LinkedinClone.ViewModels;
using LinkedinClone.Views;
using Microsoft.Extensions.Logging;

namespace LinkedinClone
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            
            FormHandler.RemoveBorders();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<Emploi>();
            builder.Services.AddTransient<Reseau>();
            builder.Services.AddTransient<Home>();
            builder.Services.AddTransient<Notication>();


            builder.Services.AddTransient<MainPageViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
