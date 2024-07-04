using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LinkedinClone.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LinkedinClone.Views;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;

namespace LinkedinClone.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ContentView _myContent;
        
        [ObservableProperty]
        private Menu _selectedMenu;
        public ObservableCollection<Menu> Menus { get; set; }

        private IPopupService _popupService;

        public MainPageViewModel(IPopupService PopupService)
        {
            _popupService = PopupService;
            MyContent = new Home();
            Menus = new ObservableCollection<Menu>()
            {
                new Menu() { Title= "Acceuil", Image = "home.png", Link = "MainPage"},
                new Menu() { Title= "Mon reseau", Image = "users.png", Link = "Reseau"},
                new Menu() { Title= "Post", Image = "plus.png", Link = "Post"},
                new Menu() { Title= "Notification", Image = "bell.png", Link = "Notication"},
                new Menu() { Title= "Emplois", Image = "bag.png", Link = "Emploi"}
            };
            SelectedMenu = Menus[0];
        }

        [RelayCommand]
        private void HanldeNavigate(string page)
        {
            switch (page)
            {
                case "MainPage":
                    MyContent = new Home();
                    break;
                case "Reseau":
                    MyContent = new Reseau();
                    break;
                case "Emploi":
                    MyContent = new Emploi();
                    break;
                case "Notication":
                    MyContent = new Notication();
                    break;
                default:
                    MyContent = new Home();
                    _popupService.ShowPopup<PostModalViewModel>();
                    break;
            }
        }

    }
}
