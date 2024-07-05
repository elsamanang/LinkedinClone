using LinkedinClone.ViewModels;

namespace LinkedinClone.Views;

public partial class Notication : ContentView
{
	public Notication()
	{
		InitializeComponent();
		BindingContext = new NoticationViewModel();
	}
}