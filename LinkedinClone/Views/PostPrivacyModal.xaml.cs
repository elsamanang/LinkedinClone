using CommunityToolkit.Maui.Views;
using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class PostPrivacyModal : Popup
{
	public PostPrivacyModal()
	{
		InitializeComponent();
		BindingContext = new PostPrivacyModalViewModel();
		
        this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End;
        for (int i = 450; i > -1; i -= 25)
        {
            this.Content.TranslationY = i;
            Thread.Sleep(1);
        }

    }

    private void Popup_Closed(object sender, CommunityToolkit.Maui.Core.PopupClosedEventArgs e)
    {
        this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.End;
        for (int i = 10; i < 460 ; i += 25)
        {
            this.Content.TranslationY = i;
            Thread.Sleep(1);
        }
        this.Close();
    }
}