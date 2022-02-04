namespace EmployeeApplication.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeesList;

        public MockEmployeeRepository()
        {
            _employeesList = new List<Employee>()
            {
                new Employee(){Id=1, Name="Test",Department="Test1",Email="Demo@gmail.com"},
                new Employee(){Id=2, Name="Test",Department="Test2",Email="Demo1@gmail.com"},
                new Employee(){Id=3, Name="Test",Department="Test3",Email="Demo2@gmail.com"},
                new Employee(){Id=4, Name="Test",Department="Test4",Email="Demo3@gmail.com"},
            };  
        }
        public Employee GetEmployee(int id)
        {
            return _employeesList.FirstOrDefault(x => x.Id == id);  
        }
    }
}
