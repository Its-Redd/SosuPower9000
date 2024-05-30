using SosuPower.Entities;
using SosuPower.Services;
using System.Collections.ObjectModel;

namespace SosuPower.Maui.viewmodels;

public partial class MainPageViewModel : BaseViewModel
{
    private readonly ISosuService sosuService;
    private ObservableCollection<Entities.Task> TodaysTasks { get; } = new();

    public MainPageViewModel(ISosuService sosuService)
    {
        Title = "DAGENS OPGAVER";
        this.sosuService = sosuService;
    }

    private void UpdateTasks()
    {
        var tasks = sosuService.GetTasksForEmployeeOnDate(DateTime.Now, new Employee());
        TodaysTasks.Clear();
        foreach (var task in tasks)
        {
            TodaysTasks.Add(task);
        }
    }
}