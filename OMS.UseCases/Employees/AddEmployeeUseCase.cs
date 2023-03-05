using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMS.CoreBusniess;
using OMS.UseCases.Employees.Interfaces;
using OMS.UseCases.PluginInterfaces;

namespace OMS.UseCases.Employees
{
    public class AddEmployeeUseCase : IAddEmployeeUseCase
    {
        private readonly IEmployeesRepository empolyeeRepository;

        public AddEmployeeUseCase(IEmployeesRepository empolyeeRepository)
        {
            this.empolyeeRepository = empolyeeRepository;
        }
        public async Task ExecuteAsync(Employee employee)
        {
            await empolyeeRepository.AddEmployeeAsync(employee);
        }
    }
}
