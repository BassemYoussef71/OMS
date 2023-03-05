using OMS.CoreBusniess;

namespace OMS.UseCases.Employees.Interfaces
{
    public interface IAddEmployeeUseCase
    {
        Task ExecuteAsync(Employee employee);
    }
}