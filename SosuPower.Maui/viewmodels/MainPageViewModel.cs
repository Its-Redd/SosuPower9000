using CommunityToolkit.Mvvm.Input;
using SosuPower.Entities;
using SosuPower.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Task = System.Threading.Tasks.Task;

namespace SosuPower.Maui.viewmodels;

public partial class MainPageViewModel : BaseViewModel
{
    private readonly ISosuService sosuService;
    public ObservableCollection<Entities.Task> TodaysTasks { get; } = new();

    public MainPageViewModel(ISosuService sosuService)
    {
        Title = "DAGENS OPGAVER";
        this.sosuService = sosuService;
        UpdateTasksAsync();
    }

    [RelayCommand]
    private async Task UpdateTasksAsync()
    {
        if (IsBusy) return;

        try
        {
            IsBusy = true;
            DateTime date = DateTime.Now;


            Employee employee = new() { EmployeeId = 2 }; // Hardcoded data, pls removals
            var tasks = await sosuService.GetTasksForAsync(date, employee);

            if (TodaysTasks.Count != 0)
            {
                TodaysTasks.Clear();
            }

            foreach (var task in tasks)
            {
                TodaysTasks.Add(task);
            }

        }
        catch (Exception ex)
        {
            // Log error
            Console.WriteLine(ex.Message);
            Debug.WriteLine(ex.InnerException);
        }
        finally
        {
            IsBusy = false;
        }
    }
}