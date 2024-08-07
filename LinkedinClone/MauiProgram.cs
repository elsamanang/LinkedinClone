﻿using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
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
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<EmploiViewModel>();
            builder.Services.AddTransient<ReseauViewModel>();
            builder.Services.AddTransient<NoticationViewModel>();
            builder.Services.AddTransient<PostModalViewModel>();
            builder.Services.AddTransient<PostPrivacyModalViewModel>();
            builder.Services.AddTransient<ProgrammerModalViewModel>();
            builder.Services.AddTransient<ProfilModalViewModel>();
            builder.Services.AddTransient<EmploiMenuModalViewModel>();
            builder.Services.AddTransient<NoticationModalViewModel>();
            builder.Services.AddTransient<MessageModalViewModel>();

            builder.Services.AddTransient<IPopupService, PopupService>();
            builder.Services.AddTransientPopup<PostModal, PostModalViewModel>();
            builder.Services.AddTransientPopup<PostPrivacyModal, PostPrivacyModalViewModel>();
            builder.Services.AddTransientPopup<ProgrammerModal, ProgrammerModalViewModel>();
            builder.Services.AddTransientPopup<ProfilModal, ProfilModalViewModel>();
            builder.Services.AddTransientPopup<EmploiMenuModal, EmploiMenuModalViewModel>();
            builder.Services.AddTransientPopup<NoticationModal, NoticationModalViewModel>();
            builder.Services.AddTransientPopup<MessageModal, MessageModalViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
