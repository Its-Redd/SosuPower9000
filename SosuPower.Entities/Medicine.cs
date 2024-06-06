namespace SosuPower.Entities
{
    public class Medicine
    {
        #region Fields
        private int medicineId;
        private int name;
        #endregion

        #region Constructors

        public Medicine(int medicineId, int name)
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

        public int Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion
    }
}
