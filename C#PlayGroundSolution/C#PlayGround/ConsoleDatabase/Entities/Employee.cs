namespace ConsoleDatabase.Entities
{
    public class Employee
    {
        public int Id {get;set;}
        public decimal Salary {get;set;}

        public IEnumerable<Employee> GetSomeData()
        {
            List<Employee> employees = new List<Employee>() {
                new Employee() {Id = 1, Salary = 300.5m},
                new Employee() {Id = 2, Salary = 400.5m},
                new Employee() {Id = 3, Salary = 500.5m},
                new Employee() {Id = 4, Salary = 600.5m}
            };

            return employees;
        }
    }
}