using SosuPower.Maui.viewmodels;

namespace SosuPower.Maui.views;

public partial class TaskPage : ContentPage
{
    public TaskPage(TaskPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}