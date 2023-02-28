using OMS.CoreBusniess;

namespace OMS.UseCases.Employees.Interfaces
{
    public interface IViewEmployeesByNamUseCasee
    {
        Task<IEnumerable<Employee>> ExecuteAsync(string name = "");
    }
}