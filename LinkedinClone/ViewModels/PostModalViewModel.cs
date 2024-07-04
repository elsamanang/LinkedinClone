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
        public PostModalViewModel() 
        {
            Title = "My modal";
        }

        [RelayCommand]
        public async Task HandleClose(Popup popup)
        {
            popup.Close();
        }
    }
}
