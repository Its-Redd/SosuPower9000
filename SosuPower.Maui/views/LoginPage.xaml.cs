using SosuPower.Maui.viewmodels;

namespace SosuPower.Maui.views;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}