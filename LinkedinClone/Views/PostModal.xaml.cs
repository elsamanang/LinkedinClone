using CommunityToolkit.Maui.Views;
using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class PostModal : Popup
{
	public PostModal()
	{
		InitializeComponent();
		BindingContext = new PostModalViewModel();
	}
}