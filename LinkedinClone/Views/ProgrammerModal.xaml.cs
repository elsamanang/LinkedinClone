using CommunityToolkit.Maui.Views;
using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class ProgrammerModal : Popup
{
	public ProgrammerModal()
	{
		InitializeComponent();
		BindingContext = new ProgrammerModalViewModel();

    }
}