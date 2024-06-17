using SosuPower.Maui.viewmodels;

namespace SosuPower.Maui.Views
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
