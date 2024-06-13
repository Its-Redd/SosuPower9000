﻿using SosuPower.Entities;

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
            string url = $"{baseUri}{uri}";
            return await client.GetAsync(url);
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


}
