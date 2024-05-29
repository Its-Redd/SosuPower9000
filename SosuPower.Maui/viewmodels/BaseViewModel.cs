using CommunityToolkit.Mvvm.ComponentModel;

namespace SosuPower.Maui.viewmodels
{
    public partial class BaseViewModel : ObservableObject
    {
        #region Fields
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(isNotBusy))]
        private bool isBusy;

        [ObservableProperty]
        private string title;
        #endregion

        #region Constructor

        public BaseViewModel()
        {

        }
        #endregion


        #region Properties
        public bool isNotBusy => !isBusy;
        #endregion
    }

}
