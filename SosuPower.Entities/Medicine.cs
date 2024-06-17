namespace SosuPower.Entities
{
    public class Medicine
    {
        #region Fields
        private int medicineId;
        private string name;
        #endregion

        #region Constructors

        public Medicine(int medicineId, string name)
        {
            MedicineId = medicineId;
            Name = name;
        }
        #endregion

        #region Properties

        public int MedicineId
        {
            get { return medicineId; }
            set { medicineId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion
    }
}
