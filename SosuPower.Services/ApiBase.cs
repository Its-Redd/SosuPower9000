using SosuPower.Entities;

namespace SosuPower.Services
{
    public abstract class ApiBase
    {
        protected Uri baseUri;
        protected HttpClient client;

        protected ApiBase(Uri baseUri)
        {
            this.baseUri = baseUri;

            HttpClientHandler handler = new HttpClientHandler();
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true; // Ignore SSL certificate errors 
            }

            // Overvej at sætte en max limit på vente tid ifh.t. til at hente data fra API'en.
            // Hvis den er off, kan du satme vente længe.

            client = new HttpClient(handler);
        }

        protected ApiBase(string uri) : this(new Uri(uri))
        {

        }

        /// <summary>
        /// Sends an HTTP GET request to the specified URI.
        /// </summary>
        /// <param name="uri">The URI to send the request to.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the HTTP response message.</returns>
        protected virtual async Task<HttpResponseMessage> GetHttpAsync(string uri)
        {
            try
            {
                string url = $"{baseUri}{uri}";
                var res = await client.GetAsync(url);
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    /// <summary>
    /// Interface for the SOSU service.
    /// </summary>
    public interface ISosuService
    {
        /// <summary>
        /// Gets the tasks for the specified date and employee asynchronously.
        /// </summary>
        /// <param name="date">The date to get the tasks for.</param>
        /// <param name="employee">The employee to get the tasks for.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the list of tasks.</returns>
        Task<List<Entities.Task>> GetTasksForAsync(DateTime date, Employee employee);
    }


    public interface IUserService
    {
        Employee Employee { get; set; }
        Task<Employee> GetUserAsync(int userId);
    }


    public interface ISubTaskService
    {
        /// <summary>
        /// Gets the subtasks for the specified task asynchronously.
        /// </summary>
        /// <param name="taskId">The ID of the task to get the subtasks for.</param>
        /// <returns>A task representing the asynchronous operation. The task result contains the list of subtasks.</returns>
        Task<List<SubTask>> GetSubTasksForTaskAsync(int taskId);
    }


}
