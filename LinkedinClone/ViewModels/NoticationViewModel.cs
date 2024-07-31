﻿using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinClone.ViewModels
{
    public partial class NoticationViewModel : BaseViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotSearching))]
        private bool _isSearching;
        public bool IsNotSearching => !IsSearching;

        private IPopupService _popupService;

        public NoticationViewModel(IPopupService popupService)
        {
            IsSearching = false;
            _popupService = popupService;
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
        private void HandleSetting()
        {
            _popupService.ShowPopup<NoticationModalViewModel>();
        }

        [RelayCommand]
        private void HandleMessage()
        {
            _popupService.ShowPopup<MessageModalViewModel>();
        }
    }
}
