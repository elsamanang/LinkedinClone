using CommunityToolkit.Maui.Views;
using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class ProfilModal : Popup
{
	public ProfilModal()
	{
		InitializeComponent();
		BindingContext = new ProfilModalViewModel();

    }

    private async void Popup_Opened(object sender, CommunityToolkit.Maui.Core.PopupOpenedEventArgs e)
    {
        this.HorizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start;
        for (int i = -240; i < 1; i += 40)
        {
            this.Content.TranslationX = i;
            await HanldeDelay();
        }
    }

    private async void Popup_Closed(object sender, CommunityToolkit.Maui.Core.PopupClosedEventArgs e)
    {
        this.HorizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Start;
        
        for (int i = -40; i > -280; i -= 40)
        {
            this.Content.TranslationX = i;
            await HanldeDelay();
        }
    }

    public Task HanldeDelay()
    {
        return Task.Delay(1);
    }
}