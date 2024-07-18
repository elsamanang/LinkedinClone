using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinClone.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotSearching))]
        private bool _isSearching;
        public bool IsNotSearching => !IsSearching;
        private IPopupService? _popupService { get; }

        public HomeViewModel()
        {
            IsSearching = false;
            Title = "My Home Page";
        }

        [RelayCommand]
        private void HandleSearching()
        {
            IsSearching = !IsSearching;
        }

        [RelayCommand]
        private void HandleProfile()
        {
            _popupService?.ShowPopup<ProfilModalViewModel>();
        }
    }
}
