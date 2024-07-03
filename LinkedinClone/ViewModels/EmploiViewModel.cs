using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinClone.ViewModels
{
    public partial class EmploiViewModel : BaseViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotSearching))]
        private bool _isSearching;
        public bool IsNotSearching => !IsSearching;

        public EmploiViewModel()
        {
            IsSearching = false;
        }

        [RelayCommand]
        private void HandleSearching()
        {
            IsSearching = !IsSearching;
        }
    }
}
