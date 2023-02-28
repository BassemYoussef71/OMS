
using OMS.CoreBusniess;
using OMS.UseCases.Employees.Interfaces;
using OMS.UseCases.PluginInterfaces;

namespace OMS.UseCases.Employees
{
    public class ViewEmployeesByNamUseCasee : IViewEmployeesByNamUseCasee
    {
        private readonly IEmployeesRepository employeeRepository;

        public ViewEmployeesByNamUseCasee(IEmployeesRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public async Task<IEnumerable<Employee>> ExecuteAsync(string name = "")
        {
            return await employeeRepository.GetEmployeesByNameAsync(name);
        }
    }
}