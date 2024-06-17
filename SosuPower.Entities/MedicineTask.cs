namespace SosuPower.Entities
{
    public class MedicineTask
    {
        #region Fields

        private int medicineTaskId;
        private string name;
        private bool completed;
        private Medicine medicine;
        private string unit;
        private int amount;

        #endregion 

        #region Constructors

        public MedicineTask()
        { }

        // Det her er et godt eksempel, på hvordan vi bruger vores properties - så vi kan data checke.
        // I stedet for at sætte det direkte på vores fields. Hvordan sikre du objektets tilstand på andre måder?
        public MedicineTask(int medicineTaskId, string name, bool isCompleted, Medicine medicine, string unit, int amount)
        {
            MedicineTaskId = medicineTaskId;
            Name = name;
            Completed = isCompleted;
            Medicine = medicine;
            Unit = unit;
            Amount = amount;
        }

        #endregion

        #region Properties

        public int MedicineTaskId
        {
            get { return medicineTaskId; }
            set { medicineTaskId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }

        public Medicine Medicine
        {
            get { return medicine; }
            set { medicine = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        #endregion
    }
}
