using OMS.CoreBusniess;
using OMS.UseCases.PluginInterfaces;

namespace OMS.Plugins.InMemory
{
    public class EmployeeRepository : IEmployeesRepository
    {
        private List<Employee> _employees;
        public EmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee{EmployeeId=1,FirstName="Bassem",LastName="Youssef",
                    Address="70 Ali Amin Street",City="Cairo",Country="Egypt",PostalCode="123456",
                    Phone="0123456789",Region="Nasr City",UserName="bassem.youssef",
                    ImageUrl="Images/emp1",
                    UserPassword="b71y19",Title="Mr."},
                new Employee{EmployeeId=2,FirstName="Barsoum",LastName="Hannah",
                    UserName="BarsoumSaad",UserPassword="123456"},
                new Employee{EmployeeId=3,FirstName="Youssef",LastName="Wahba",
                    UserName="Youssef.Wahba",UserPassword="Yw123456"},
                new Employee{EmployeeId=4,FirstName="Ahmed",LastName="Kasem",
                    UserName="Yasser.Kasem",UserPassword="Yk123456"}


            };
        }
        public async Task<IEnumerable<Employee>> GetEmployeesByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name)) return await Task.FromResult(_employees);
            return _employees.Where(x => x.FirstName.Contains(name,
                StringComparison.OrdinalIgnoreCase) || x.LastName.Contains(name,
                StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}