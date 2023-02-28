using OMS.CoreBusniess;

namespace OMS.UseCases.PluginInterfaces
{
    public interface IEmployeesRepository
    {
        Task<IEnumerable<Employee>> GetEmployeesByNameAsync(string name);
    }
}
