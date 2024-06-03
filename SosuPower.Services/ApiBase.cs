using SosuPower.Entities;
using System.Diagnostics;
using System.Net.Http.Json;
using Task = SosuPower.Entities.Task;

namespace SosuPower.Services
{
    // Probably my favorite class in the project cause its so cool
    public abstract class ApiBase
    {
        protected Uri baseUri;
        protected HttpClient client;


        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;

            HttpClientHandler handler = new HttpClientHandler();
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            client = new HttpClient(handler);
        }

        protected ApiBase(string uri) : this(new Uri(uri))
        {

        }

        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string uri)
        {
            string url = $"{baseUri}{uri}";
            return await client.GetAsync(url);
        }
    }

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

                var response = await GetHttpAsync("Task/GetAssignmentsForEmployeeByDate?employeeId=4&date=2024-05-23");
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

    public interface ISosuService
    {
        Task<List<Task>> GetTasksForAsync(DateTime date, Employee employee);
    }
}
