using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinClone.ViewModels
{
    public partial class PostModalViewModel: BaseViewModel
    {
        private IPopupService _popupService;

        public PostModalViewModel(IPopupService popupService) 
        {
            _popupService = popupService;
            Title = "My modal";
        }

        [RelayCommand]
        public async Task HandleClose(Popup popup)
        {
            popup.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End;
            for (int i = 50; i < 800; i += 50)
            {
                popup.Content.TranslationY = i;
                await HanldeDelay();
            }
            popup.Close();
        }

        public Task HanldeDelay()
        {
            return Task.Delay(1);
        }

        [RelayCommand]
        public async Task HandlePrivacy()
        {
            await _popupService.ShowPopupAsync<PostPrivacyModalViewModel>();
        }

        [RelayCommand]
        public async Task HandleProgrammer()
        {
            await _popupService.ShowPopupAsync<ProgrammerModalViewModel>();
        }
    }
}
