using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LinkedinClone.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinClone.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private int _top;

        [ObservableProperty]
        private int _down;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotSearching))]
        private bool _isSearching;
        public bool IsNotSearching => !IsSearching;

        [ObservableProperty]
        private List<string> _elements;
        
        public ObservableCollection<Menu> Menus { get; set; }

        public MainPageViewModel()
        {
            IsSearching = false;
            Top = 50;
            Down = 50;
            Menus = new ObservableCollection<Menu>()
            {
                new Menu() { Title= "Acceuil", Image = "home.png", Link = "MainPage"},
                new Menu() { Title= "Mon reseau", Image = "users.png", Link = "Reseau"},
                new Menu() { Title= "Post", Image = "plus.png", Link = "Post"},
                new Menu() { Title= "Notification", Image = "bell.png", Link = "Notication"},
                new Menu() { Title= "Emplois", Image = "bag.png", Link = "Emploi"}
            };
            Elements = new List<string>()
            {
                "elm 1",
                "elm 2",
                "elm 3",
                "elm 4",
                "elm 5",
                "elm 6",
                "elm 7",
                "elm 8",
                "elm 9",
                "elm 10",
                "elm 11",
                "elm 4",
                "elm 1",
                "elm 2",
                "elm 3",
                "elm 4",
                "elm 1",
                "elm 2",
                "elm 3",
                "elm 4",
                "elm 1",
                "elm 2",
                "elm 3",
                "elm 4",
            };
        }

        [RelayCommand]
        private void HandleUp()
        {
            Top = 0;
            Down = 0;
        }
        
        [RelayCommand]
        private void HandleDown()
        {
            Top = 50;
            Down = 50;
        }

        [RelayCommand]
        private void HandleSearching()
        {
            IsSearching = !IsSearching;
        }

        [RelayCommand]
        private void HanldeNavigate(string page)
        {
            switch (page)
            {
                case "MainPage":
                    Console.WriteLine("home");
                    break;
                case "Reseau":
                    Console.WriteLine("mon reseau");
                    break;
                case "Emploi":
                    Console.WriteLine("mes jobs");
                    break;
                case "Notication":
                    Console.WriteLine("mes jobs");
                    break;
                default:
                    break;
            }
        }

    }
}
