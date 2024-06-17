using CommunityToolkit.Mvvm.ComponentModel;
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
    private IUserService userService;
    public ObservableCollection<Entities.Task> TodaysTasks { get; } = new();

    [ObservableProperty]
    private Employee user;


    public MainPageViewModel(ISosuService sosuService, IUserService userService)
    {
        Title = "DAGENS OPGAVER";
        this.sosuService = sosuService;
        this.userService = userService;
        User = userService.Employee;
        UpdateTasksAsync();
    }

    /// <summary>
    /// Updates the tasks asynchronously.
    /// </summary>
    [RelayCommand]
    private async Task UpdateTasksAsync()
    {
        if (IsBusy) return;

        try
        {
            IsBusy = true;
            DateTime date = DateTime.Now;

            var tasks = await sosuService.GetTasksForAsync(date, userService.Employee);

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
