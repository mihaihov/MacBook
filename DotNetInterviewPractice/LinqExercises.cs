using Entities;

namespace LinqExercises {
    public static class LinqExercises
    {
        public static List<int> RemoveEvenNumbers(List<int> list)
        {
            list = list.Where(x => x % 2 == 0).ToList();
            list.Sort((x,y) => y.CompareTo(x));
            return list;
        }

        public static string FirstWordStartingWithLetter(List<string> list, char c)
        {
            var result = list.Find(x => x.StartsWith(c));
            if(string.IsNullOrEmpty(result))
                throw new Exception("String not found");
            return result;
        }

        public static int SumOfEvenNumbers(List<int> list)
        {
            return list.Where(x => x%2 != 0).Sum();
        }

        public static void GroupByLength(List<string> list){
            IEnumerable<IGrouping<int,string>> result = list.GroupBy(x => x.Length);
            foreach(IGrouping<int,string> group in result)
            {
                Console.WriteLine(group.Key);
                foreach(string x in group)
                {
                    Console.Write(x + ", ");
                }
                Console.WriteLine();
            }
        }

        public static void ListToDictionary(List<Customer> list)
        {
            Dictionary<int,string> result = list.ToDictionary(x => x.Age, x => x.Name);


            foreach(KeyValuePair<int,string> dic in result)
            {
                Console.WriteLine($"{dic.Key} :  {dic.Value}");
            }
        }

        public static void Top3LongestWords(List<string> list)
        {
            list.Sort((x,y) => y.Length.CompareTo(x.Length));
            var result = list.Take(3);
            foreach(string word in result)
            {
                Console.WriteLine(word);
            }
        }

        public static void CountWordsThatContainSpecificLetter(List<string> list)
        {
            Console.WriteLine(list.Where(x => x.Contains("e")).Count());
        }

        public static void FlattenLists(List<List<int>> list)
        {
            var result = list.ToList();
            Console.WriteLine("End");
        }
        public static void AverageAge(List<Customer> list)
        {
            Console.WriteLine(list.Average(x => x.Age));
        }
    }
}