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

        public static decimal? NthHighestSalary(IEnumerable<Employee> data, int n)
        {
            if( n < 0 || n > data.Count()) return null;
            return data.Select(g => g.Salary).OrderByDescending(s => s).ToList()[n - 1];
        }

        public static void RankScores(IEnumerable<Score> scores)
        {
            ///this is a LeetCode exercise.

            //groups the elements by the Score
            IEnumerable<IGrouping<decimal,Score>> rankedScores = scores.GroupBy(s => s.ScoreValue);

            //LEARNING NOTES:
            // 1. GroupBy => IEnumerable<IGroupping<TKey, TResult>> - think of it as an index (key) which points to a group of objects
            // 2. SelectMany => Takes in a Collection of Collections and flattens them into a IEnumerable<T>.


            //foreach group (it keeps track of a integer called index) - foreach object in that group - 
                //builds a new object with ID, ScoreValue and the rank (Rank = index). All are converted to an IEnumerable<T>
                //using SelectMany.
            var result = rankedScores.SelectMany((group, index) => {
                index++; return group.Select(s => new {
                    s.Id,
                    s.ScoreValue,
                    Rank = index
                });
            }).ToList();

            foreach(var o in result)
            {
                Console.WriteLine($"{o.Id} - {o.ScoreValue} - {o.Rank}");
            }
        }
    }
}