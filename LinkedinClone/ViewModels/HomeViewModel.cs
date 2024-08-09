using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LinkedinClone.Models;
using LinkedinClone.Utiles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        [ObservableProperty]
        public ObservableCollection<Post> _posts;
        public bool IsNotSearching => !IsSearching;
        private IPopupService _popupService;

        public HomeViewModel(IPopupService popupService)
        {
            _popupService = popupService;
            IsSearching = false;
            Title = "My Home Page";
            var data = MockGenerator.GeneratePosts(20);
            Posts = new ObservableCollection<Post>(data.OrderByDescending(p => p.DateCreation));
        }

        [RelayCommand]
        private void HandleSearching()
        {
            IsSearching = !IsSearching;
        }

        [RelayCommand]
        private void HandleProfile()
        {
            _popupService.ShowPopup<ProfilModalViewModel>();
        }

        [RelayCommand]
        private void HandleMessage()
        {
            _popupService.ShowPopup<MessageModalViewModel>();
        }
    }
}
