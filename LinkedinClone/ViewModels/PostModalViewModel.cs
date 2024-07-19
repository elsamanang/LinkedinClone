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
        public void HandleClose(Popup popup)
        {
            popup.Close();
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
