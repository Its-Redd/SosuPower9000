using SosuPower.Entities;
using System.Net.Http.Json;
using Task = SosuPower.Entities.Task;

namespace SosuPower.Services
{
    // Probably my favorite class in the project cause its so cool
    public abstract class ApiBase
    {
        protected Uri baseUri;

        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;
        }

        protected ApiBase(string uri) : this(new Uri(uri))
        {

        }

        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string uri)
        {
            string url = $"{baseUri}{uri}";
            using HttpClient client = new();
            client.BaseAddress = baseUri;
            return await client.GetAsync(uri);
        }

        protected virtual async Task<HttpResponseMessage> PostHttpAsync(string uri, object content)
        {
            string url = $"{baseUri}{uri}";
            using HttpClient client = new();
            client.BaseAddress = baseUri;
            return await client.PostAsJsonAsync(uri, content);
        }

        protected virtual async Task<HttpResponseMessage> PutHttpAsync(string uri, object content)
        {
            string url = $"{baseUri}{uri}";
            using HttpClient client = new();
            client.BaseAddress = baseUri;
            return await client.PutAsJsonAsync(uri, content);
        }

        protected virtual async Task<HttpResponseMessage> DeleteHttpAsync(string uri)
        {
            string url = $"{baseUri}{uri}";
            using HttpClient client = new();
            client.BaseAddress = baseUri;
            return await client.DeleteAsync(uri);
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
            UriBuilder uriBuilder = new UriBuilder(baseUri);
            uriBuilder.Path = "api/Task";
            using HttpClient client = new();
            client.BaseAddress = uriBuilder.Uri;

            var response = await GetHttpAsync("api/Task/");
            var result = response.Content.ReadFromJsonAsAsyncEnumerable<Entities.Task>();
            List<Entities.Task> tasks = await result.ToListAsync();

            return tasks;
        }
    }

    public interface ISosuService
    {
        Task<List<Task>> GetTasksForAsync(DateTime date, Employee employee);
    }
}
