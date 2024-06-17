using SosuPower.Entities;
using System.Diagnostics;
using System.Net.Http.Json;

namespace SosuPower.Services
{
    public class UserService : ApiBase, IUserService
    {

        public UserService(Uri baseUri) : base(baseUri)
        {
            // Initialize the service
        }

        public UserService(string baseUri) : base(baseUri)
        {
            // Initialize the service
        }

        private int userId;

        public Employee Employee { get; set; }

        public async Task<Employee> GetUserAsync(int userId)
        {
            try
            {
                var response = await GetHttpAsync($"Employee/GetEmployeeById?employeeId={userId}");
                Employee = await response.Content.ReadFromJsonAsync<Employee>();
                return Employee;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Debug.WriteLine(e.InnerException);
                throw;
            }
        }


    }
}
