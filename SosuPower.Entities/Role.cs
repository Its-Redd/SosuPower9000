namespace SosuPower.Entities
{
    public class Role
    {
        #region Fields
        private int roleId;
        private string roleName;
        #endregion

        #region Constructors
        public Role(int roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
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
        #endregion
    }
}
