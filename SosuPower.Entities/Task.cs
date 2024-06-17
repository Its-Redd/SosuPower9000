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
        private List<MedicineTask> medicineTask;
        private List<SubTask> subTask;
        private bool completed;

        #endregion

        #region Constructors

        public Task()
        {
            this.employees = new List<Employee>(); // Initialize to prevent null reference issues

            // Vi bruger vores property, så vi kan data checke.
            MedicineTasks = new List<MedicineTask>();
            SubTasks = new List<SubTask>();
            
        }

        public Task(int taskId, DateTime timeStart, DateTime timeEnd, Resident resident,
                    List<Employee> employees, List<MedicineTask> medicines, List<SubTask> subTasks, bool completed)
        {
            this.taskId = taskId;
            this.timeStart = timeStart;
            this.timeEnd = timeEnd;
            this.resident = resident;
            this.employees = employees ?? new List<Employee>();
            MedicineTasks = medicines ?? new List<MedicineTask>();
            SubTasks = subTasks ?? new List<SubTask>();
            this.completed = completed;
        }

        #endregion

        #region Properties

        // Sker automatisk, når vi bruger Entity Framework.
        // Så længe den hedder "Entitet"Id, så er det en primary key.
        // Hvis ikke, får du fejl - og skal måske bruge [Key] annotation.
        // Men det roder din kode... - så bare gør som EF siger.
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

        // Ikke nødvendig, propertien er ikke nullable.
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

        public virtual List<MedicineTask> MedicineTasks
        {
            get { return medicineTask; }
            set { medicineTask = value; }
        }

        public virtual List<SubTask> SubTasks
        {
            get { return subTask; }
            set { subTask = value; }
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
