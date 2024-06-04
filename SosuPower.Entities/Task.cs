using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SosuPower.Entities
{
    public class Task
    {
        #region Fields

        private int taskId;
        private DateTime timeStart;
        private DateTime timeEnd;
        private Resident resident;
        private List<Employee> employees;
        private List<Medicine> medicines;
        private bool completed;

        #endregion

        #region Constructors

        public Task()
        {
            this.employees = new List<Employee>(); // Initialize to prevent null reference issues
            this.medicines = new List<Medicine>(); // Initialize to prevent null reference issues
        }

        public Task(int taskId, DateTime timeStart, DateTime timeEnd, Resident resident,
                    List<Employee> employees, List<Medicine> medicines, bool completed)
        {
            this.taskId = taskId;
            this.timeStart = timeStart;
            this.timeEnd = timeEnd;
            this.resident = resident;
            this.employees = employees ?? new List<Employee>();
            this.medicines = medicines ?? new List<Medicine>();
            this.completed = completed;
        }

        #endregion

        #region Properties

        [Key]
        public int TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }


        [Required]
        public DateTime TimeStart
        {
            get { return timeStart; }
            set { timeStart = value; }
        }

        [Required]
        public DateTime TimeEnd
        {
            get { return timeEnd; }
            set { timeEnd = value; }
        }

        [ForeignKey("ResidentId")]
        public virtual Resident Resident
        {
            get { return resident; }
            set { resident = value; }
        }

        public int ResidentId { get; set; }

        public virtual List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public virtual List<Medicine> Medicines
        {
            get { return medicines; }
            set { medicines = value; }
        }


        [Required]
        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }

        #endregion
    }
}
