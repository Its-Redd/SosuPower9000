namespace SosuPower.Entities
{
    public class Role
    {
        #region Fields
        private int roleId;
        private string roleName;
        private List<Employee> employees;
        #endregion

        #region Constructors
        public Role()
        {
            Employees = new List<Employee>();
        }

        public Role(int roleId, string roleName, List<Employee> employees)
        {
            RoleId = roleId;
            RoleName = roleName;
            Employees = employees ?? new List<Employee>();
        }
        #endregion

        #region Properties
        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }

        public string RoleName
        {
            get { return roleName; }
            set { roleName = value; }
        }

        public virtual List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        #endregion
    }
}
