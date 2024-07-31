using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class Notication : ContentView
{
	public Notication(NoticationViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}