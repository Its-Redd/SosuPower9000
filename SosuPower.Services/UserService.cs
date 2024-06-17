using SosuPower.Entities;
using System.Data;
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
        public Employee Employee { get; set; }

        public async Task<Employee> GetUserAsync(int userId)
        {
            try
            {
                var response = await GetHttpAsync($"Employee/{userId}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new DataException("Brugeren kunne ikke hentes.");
                }

                var res = await response.Content.ReadFromJsonAsync<Employee>();
                Employee = res;
                return res;
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
