using CommunityToolkit.Maui.Core;
using LinkedinClone.ViewModels;

namespace LinkedinClone.Views {

	public partial class Home : ContentView
	{
		public Home()
		{
			InitializeComponent();
			BindingContext = new HomeViewModel();
		}
	}
}