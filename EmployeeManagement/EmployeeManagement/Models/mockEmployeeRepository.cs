namespace EmployeeManagement.Models
{
    public class mockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public mockEmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Demo", Department ="HR",Email ="Demo@gmail.com"},
                new Employee(){ Id = 2, Name = "Demo", Department ="HR",Email ="Demo@gmail.com"},
                new Employee(){ Id = 3, Name = "Demo", Department ="HR",Email ="Demo@gmail.com"},
                new Employee(){ Id = 4, Name = "Demo", Department ="HR",Email ="Demo@gmail.com"},
            };
        } 
        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(x => x.Id == id);  
        }
    }
}
