using ConsoleDatabase.Entities;

namespace LeetCode
{
    public static class SQLExercises
    {
        public static decimal? SecondHighestSalary(IEnumerable<Employee> data)
        {
            //option 1
            var result = data.Select(e => (decimal?)e.Salary)
                .Where(s => s < data.Max(em => em.Salary))
                .DefaultIfEmpty(null)
                .Max();
                
            return result;

            //option 2
            // Console.WriteLine(data.OrderByDescending(e => e.Salary).Take(2).ToList()[1].Salary);
        }
    }
}