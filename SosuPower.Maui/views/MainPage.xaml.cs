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

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }


        private void Button_OnClicked_(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

}
