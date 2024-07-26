using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LinkedinClone.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using LinkedinClone.Views;
using CommunityToolkit.Maui.Core;

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
            var viewModel = new HomeViewModel(_popupService);
            MyContent = new Home(viewModel);
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
                    var homeViewModel = new HomeViewModel(_popupService);
                    MyContent = new Home(homeViewModel);
                    break;
                case "Reseau":
                    var reseauViewModel = new ReseauViewModel(_popupService);
                    MyContent = new Reseau(reseauViewModel);
                    break;
                case "Emploi":
                    var emploiViewModel = new EmploiViewModel(_popupService);
                    MyContent = new Emploi(emploiViewModel);
                    break;
                case "Notication":
                    var noticationViewModel = new NoticationViewModel(_popupService);
                    MyContent = new Notication(noticationViewModel);
                    break;
                default:
                    var omeViewModel = new HomeViewModel(_popupService);
                    MyContent = new Home(omeViewModel);
                    _popupService.ShowPopup<PostModalViewModel>();
                    break;
            }
        }

    }
}
