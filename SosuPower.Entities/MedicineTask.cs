namespace SosuPower.Entities
{
    public class MedicineTask : SubTask

    {

        #region Fields

        private Medicine medicine;
        private int amount;
        private string unit;

        #endregion

        #region Constructors

        public MedicineTask()
        {

        }

        public MedicineTask(int subTaskId, string description, bool completed, Medicine medicine, int amount, string unit)
            : base(subTaskId, description, completed)
        {
            this.medicine = medicine;
            this.amount = amount;
            this.unit = unit;
        }

        #endregion

        #region Properties

        public Medicine Medicine
        {
            get { return medicine; }
            set { medicine = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        #endregion



    }
}
