using SosuPower.Entities;
using System.Diagnostics;
using System.Net.Http.Json;
using Task = SosuPower.Entities.Task;

namespace SosuPower.Services;

public class SosuService : ApiBase, ISosuService
{
    public SosuService(Uri baseUri) : base(baseUri)
    {
        // Initialize the service
    }
    public SosuService(string baseUri) : base(baseUri)
    {
        // Initialize the service
    }

    public async Task<List<Entities.Task>> GetTasksForAsync(DateTime date, Employee employee)
    {
        List<Task> tasks;
        try
        {
            // Hardcoded date for testing purposes
            date = new DateTime(2022, 1, 1);
            // Remember to out comment the hardcoded date

            var response = await GetHttpAsync($"Task/GetAssignmentsForEmployeeByDate?employeeId={employee.EmployeeId}&date={date.ToString("yyyy-MM-dd")}");
            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Task>();
            tasks = await result.ToListAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Debug.WriteLine(e.InnerException);
            throw;
        }

        return tasks;
    }
}