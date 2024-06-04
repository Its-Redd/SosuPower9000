namespace SosuPower.Entities
{
    public class SubTask
    {
        #region Fields

        private int subTaskId;
        private string description;
        private bool completed;

        #endregion

        #region Constructors

        public SubTask()
        {
        }

        public SubTask(int subTaskId, string description, bool completed)
        {
            this.subTaskId = subTaskId;
            this.description = description;
            this.completed = completed;
        }



        #endregion

        #region Properties

        public int SubTaskId
        {
            get { return subTaskId; }
            set { subTaskId = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }

        #endregion
    }
}
