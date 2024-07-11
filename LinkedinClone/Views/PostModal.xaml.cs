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
}