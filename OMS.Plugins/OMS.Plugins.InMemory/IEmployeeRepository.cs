using OMS.CoreBusniess;

namespace OMS.Plugins.InMemory
{
    public interface IEmployeeRepository
    {
        Task AddEmployeeAsync(Employee employee);
        Task<IEnumerable<Employee>> GetEmployeesByNameAsync(string name);
    }
}