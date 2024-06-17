using SosuPower.Entities;
using System.Diagnostics;
using System.Net.Http.Json;
using Task = SosuPower.Entities.Task;

namespace SosuPower.Services;

public class TaskService : ApiBase, ISosuService
{
    public TaskService(Uri baseUri) : base(baseUri)
    {
        // Initialize the service
    }
    public TaskService(string baseUri) : base(baseUri)
    {
        // Initialize the service
    }

    public async Task<List<Entities.Task>> GetTasksForAsync(DateTime date, Employee employee)
    {
        try
        {
            date = new DateTime(2024, 6, 4); // Er det bevidst du ikke har en kommentar om at slette den her???

            var response = await GetHttpAsync($"Task/GetAssignmentsForEmployeeByDate?employeeId={employee.EmployeeId}&date={date.ToString("yyyy-MM-dd")}");
            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Task>();
            List<Task> tasks = await result.ToListAsync();
            return tasks;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Debug.WriteLine(e.InnerException);
            throw;
        }

        // Hvorfor returnerer du en liste af tasks hernede, i stedet for i din try? 
    }

}