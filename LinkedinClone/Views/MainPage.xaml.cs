using LinkedinClone.ViewModels;

namespace LinkedinClone.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }


    }

}
