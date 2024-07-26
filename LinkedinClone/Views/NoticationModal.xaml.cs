using CommunityToolkit.Maui.Views;
using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class NoticationModal : Popup
{
	public NoticationModal(NoticationModalViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}