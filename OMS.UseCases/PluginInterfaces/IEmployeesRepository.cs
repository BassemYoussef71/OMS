using OMS.CoreBusniess;

namespace OMS.UseCases.PluginInterfaces
{
    public interface IEmployeesRepository
    {
    //    public void AddEmployeeAsync(Employee employee);
       Task AddEmployeeAsync(Employee employee);
        Task<IEnumerable<Employee>> GetEmployeesByNameAsync(string name);
    }
}
