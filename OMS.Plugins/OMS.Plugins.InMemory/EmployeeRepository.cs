using OMS.CoreBusniess;
using OMS.UseCases.PluginInterfaces;
using System.Runtime.CompilerServices;

namespace OMS.Plugins.InMemory
{
    public class EmployeeRepository :  IEmployeesRepository
    {
        private List<Employee> _employees;
        public EmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee{EmployeeId=1,FirstName="Bassem",LastName="Youssef",
                    Address="70 Ali Amin Street",City="Cairo",Country="Egypt",PostalCode="123456",
                    Phone="0123456789",Region="Nasr City",UserName="bassem.youssef",
                    ImageUrl="images/emp4.png",
                    UserPassword="b71y19",Title="Mr."},
                new Employee{EmployeeId=2,FirstName="Barsoum",LastName="Hannah",
                    UserName="BarsoumSaad",UserPassword="123456",
                    ImageUrl="images/emp5.jpg",Title="Mr."},

                new Employee{EmployeeId=3,FirstName="Youssef",LastName="Wahba",
                    UserName="Youssef.Wahba",UserPassword="Yw123456",Title="Mr.",
                    ImageUrl="images/emp3.jpg"},
                new Employee{EmployeeId=4,FirstName="Ahmed",LastName="Kasem",
                    UserName="Yasser.Kasem",UserPassword="Yk123456",Title="Mr.",
                    ImageUrl="images/emp4.jpg"}


            };
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(_employees);
            return _employees.Where(x => x.FirstName.Contains(name,
                StringComparison.OrdinalIgnoreCase) || x.LastName.Contains(name,
                StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public Task AddEmployeeAsync(Employee employee)
        {
            if (_employees.Any(x => x.FirstName.Equals(employee.FirstName,
                StringComparison.OrdinalIgnoreCase) && x.LastName.Equals(employee.LastName,
                StringComparison.OrdinalIgnoreCase)))
            {
                return Task.CompletedTask;
            }
            var maxid = _employees.Max(x => x.EmployeeId) + 1;
            employee.EmployeeId = maxid;
            _employees.Add(employee);
            return Task.CompletedTask;
        }
    }
}