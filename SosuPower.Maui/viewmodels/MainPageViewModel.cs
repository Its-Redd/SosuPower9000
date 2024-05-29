using System.Collections.ObjectModel;

namespace SosuPower.Maui.viewmodels;

public partial class MainPageViewModel : BaseViewModel
{
    private ObservableCollection<Entities.Task> TodaysTasks { get; } = new();

}