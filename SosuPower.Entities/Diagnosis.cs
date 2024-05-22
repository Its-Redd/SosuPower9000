namespace SosuPower.Entities
{
    public class Diagnosis
    {
        #region Fields

        private int diagnosisId;
        private string name;
        private string description;

        #endregion

        #region Constructors

        public Diagnosis(int diagnosisId, string name, string description)
        {
            DiagnosisId = diagnosisId;
            Name = name;
            Description = description;
        }

        #endregion

        #region Properties

        public int DiagnosisId
        {
            get { return diagnosisId; }
            set { diagnosisId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        #endregion
    }
}
