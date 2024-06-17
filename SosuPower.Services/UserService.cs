using SosuPower.Entities;
using System.Data;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Resources;

namespace SosuPower.Services
{
    public class UserService : ApiBase, IUserService
    {

        public UserService(Uri baseUri) : base(baseUri)
        {
            Employee = new Employee();
        }

        public UserService(string baseUri) : base(baseUri)
        {
            Employee = new Employee();
        }
        public Employee Employee { get; set; }

        public async Task<Employee> GetUserAsync(int userId)
        {
            // Fjernet try, catch så vi griber den højere i systemet. 
                var response = await GetHttpAsync($"Employee/{userId}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new DataException("Brugeren kunne ikke hentes.");
                }

                
                var res = await response.Content.ReadFromJsonAsync<Employee>() ?? throw new DataException("Brugeren kunne ikke hentes."); // Læs content. Hvis det er null, så kast en data exception.
                Employee = res;
                return res;
        }


    }
}
