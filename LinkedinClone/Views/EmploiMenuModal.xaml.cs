using CommunityToolkit.Maui.Views;
using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class EmploiMenuModal : Popup
{
	public EmploiMenuModal(EmploiMenuModalViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}