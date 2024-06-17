using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SosuPower.Maui.viewmodels
{
    public partial class BaseViewModel : ObservableObject
    {
        #region Fields

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(isNotBusy))]
        private bool isBusy;

        [ObservableProperty] private string title;

        #endregion

        #region Constructor

        public BaseViewModel()
        {

        }

        #endregion

        #region Commands

        [RelayCommand]
        private void NotImplementedError()
        {
            Shell.Current.DisplayAlert("Not Implemented", "This feature is not implemented yet.", "OK");
        }

        // Så vi kan give brugeren feedback.
        [RelayCommand]
        protected async Task Alert(string message)
        {
            await Shell.Current.DisplayAlert(Title, message, "OK");
        }

        #endregion

        #region Properties

        public bool isNotBusy => !isBusy;

        #endregion
    }
}


