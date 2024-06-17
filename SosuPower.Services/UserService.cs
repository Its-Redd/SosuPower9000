namespace SosuPower.Services
{
    public class UserService : IUserService
    {
        private int userId;

        public void SetUserId(int value)
        {
            userId = value;
        }

        public int GetUserId()
        {
            return userId;
        }
    }
}
