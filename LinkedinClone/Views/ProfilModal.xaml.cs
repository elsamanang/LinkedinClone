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
}