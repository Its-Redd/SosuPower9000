using System.Net.Http.Json;
using SosuPower.Entities;

namespace SosuPower.Services
{
    // Probably my favorite class in the project cause its so cool
    public abstract class ApiBase
    {
        protected Uri BaseUri;

        protected ApiBase(Uri baseUri)
        {
            this.BaseUri = baseUri;
        }

        protected ApiBase(string uri) : this(new Uri(uri))
        {

        }
    }

    public class SosuService : ApiBase, SosuService.ISosuService
    {
        public SosuService(Uri baseUri) : base(baseUri)
        {
            // Initialize the service
        }
        public SosuService(string baseUri) : base(baseUri)
        {
            // Initialize the service
        }

        public List<Entities.Task> GetTasksOn(DateTime date, Employee employee)
        {
            UriBuilder uriBuilder = new UriBuilder(BaseUri);
            uriBuilder.Path = "Task/GetTasksOn";
            uriBuilder.Query = $"date={date}&employee={employee}";
            using HttpClient client = new HttpClient();
            client.BaseAddress = uriBuilder.Uri;

            var response = client.GetAsync(uriBuilder.Uri.AbsoluteUri).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadFromJsonAsAsyncEnumerable<Entities.Task>();
            }
            else
            {
                // Log the error
                throw new Exception("Failed to get tasks - " + response);
            }
            return default;
        }

        public interface ISosuService
        {
            List<Entities.Task> GetTasksOn(DateTime date, Employee employee);
        }


    }
}
