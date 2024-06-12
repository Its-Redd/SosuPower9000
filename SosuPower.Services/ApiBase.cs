using SosuPower.Entities;

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

    public interface ISosuService
    {
        Task<List<Entities.Task>> GetTasksForAsync(DateTime date, Employee employee);
    }


}
