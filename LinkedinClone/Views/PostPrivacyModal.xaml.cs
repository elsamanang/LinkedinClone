using CommunityToolkit.Maui.Views;
using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class PostPrivacyModal : Popup
{
	public PostPrivacyModal()
	{
		InitializeComponent();
		BindingContext = new PostPrivacyModalViewModel();

    }
}