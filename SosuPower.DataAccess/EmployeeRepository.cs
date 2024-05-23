using SosuPower.Entities;
using Task = SosuPower.Entities.Task;

namespace SosuPower.DataAccess
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public IEnumerable<Task> GetEmployeesAt(CareCenter careCenter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Task> GetEmployeesWith(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
