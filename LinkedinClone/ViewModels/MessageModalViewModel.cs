using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Animations;
using Microsoft.Maui.Controls.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedinClone.ViewModels
{
    public partial class MessageModalViewModel : BaseViewModel
    {
        public MessageModalViewModel()
        {
            var popup = Shell.Current.FindByName("MyPopup") as Popup;

            if (popup != null)
            {
                popup.HorizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End;
                for (int i = 40; i > 0; i -= 40)
                {
                    popup.Content.TranslationX = i;
                    HanldeDelay();
                }
            }
        }


        [RelayCommand]
        public async Task HandleClose(Popup popup)
        {
            popup.HorizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End;
            for (int i = 40; i < 400; i += 40)
            {
                popup.Content.TranslationX = i;
                await HanldeDelay();
            }
            popup.Close();
        }

        public Task HanldeDelay()
        {
            return Task.Delay(1);
        }
    }
}
