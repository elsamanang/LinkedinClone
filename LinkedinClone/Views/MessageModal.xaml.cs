using CommunityToolkit.Maui.Views;
using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class MessageModal : Popup
{
	public MessageModal(MessageModalViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}