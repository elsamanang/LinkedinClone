using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class PostModal : Popup
{
	public PostModal(PostModalViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }

    private async void Popup_Opened(object sender, PopupOpenedEventArgs e)
    {
        //this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End;
        for (int i = 750; i > -1; i -= 50)
        {
            this.Content.TranslationY = i;
            await HanldeDelay();
        }
    }

    public Task HanldeDelay()
    {
        return Task.Delay(1);
    }
}