using SosuPower.Entities;

namespace SosuPower.Services
{
    public class SubTaskService : ApiBase, ISubTaskService
    {
        public SubTaskService(Uri baseUri) : base(baseUri)
        {
        }

        public SubTaskService(string uri) : base(uri)
        {
        }

        public Task<List<SubTask>> GetSubTasksForTaskAsync(int taskId)
        {
            //List<SubTask> subTasks;
            //try
            //{
            //    var response = GetHttpAsync($"SubTask/GetSubTasksForTask?taskId={taskId}");
            //    var result = response.Content.ReadFromJsonAsync<List<SubTask>>();
            //    subTasks = result.Result;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    throw;
            //}
            //return Task.FromResult(subTasks);

            throw new NotImplementedException();

        }
    }
}
