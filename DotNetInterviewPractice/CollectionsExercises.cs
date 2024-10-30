using System.Diagnostics;
using Entities;

namespace CollectionsExercises {
    public static class CollectionExercises {
        public static List<int> RemoveDuplicatesUsingDictionaries(List<int> numbers)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //creates a dictionary and stores each number from 'numbers' as a dictionary keys
            Dictionary<int,int> mapNumbersToDictionaryKeys = new Dictionary<int,int>();
            foreach (var number in numbers)
            {
                mapNumbersToDictionaryKeys[number] = 1;
            }

            //creates a list of int from the above dictionary's keys.
            List<int> result = mapNumbersToDictionaryKeys.Keys.ToList();

            //sorts the list in DEScending order
            result.Sort((x,y) => y.CompareTo(x));

            //sorts the list in AScending order
                //result.Sort();
            //sorts the list using a custom comparer
            //if tie, the descending order will be taken into consideration.
                // result.Sort((x,y) => {
                //     var reminder = (x%3).CompareTo(y%3);
                //     return reminder == 0 ? y.CompareTo(x) : reminder;
                // });
            //sorts using LINQ
                //result.Order();
                //result.OrderBy(x => x%3)
                //.ThenByDescending(x => x);
            
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"Total time for RemoveDuplicatesUsingDictionaries: {ts.TotalMilliseconds}");

            return result;
        }

        public static List<int> RemoveDuplicatesUsingHashSet(List<int> numbers)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            

            HashSet<int> result = new HashSet<int>();
            foreach(var number in numbers)
            {
                result.Add(number);
            }

            numbers = result.ToList();
            numbers.Sort();

            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"Total time for RemoveDuplicatesUsingHashSet: {ts.TotalMilliseconds}");

            return numbers;
        }

        public static Dictionary<string,int> CountWords (string myString)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Dictionary<string,int> result = new Dictionary<string,int>();
            foreach(var x in myString.Split(" "))
            {
                if(result.Keys.Contains(x))
                    result[x] ++;
                else
                    result[x] = 1;
            }

            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"Time elapsed for function CountWords: {ts.TotalMilliseconds}");

            return result;
        }

        public static void AddCustomerToQueue(Queue<Customer> myQueue, Customer customer)
        {
            myQueue.Enqueue(customer);
        }

        public static void RemoveCustomerFromQueue(Queue<Customer> myQueue)
        {
            myQueue.Dequeue();
        }

        public static bool BalancedPharentesis(Stack<char> myStack)
        {
            int sum = 0;
            while(myStack.Count > 0)
            {
                char current = myStack.Pop();
                sum = current == ')' ? ++sum : --sum;
                if(sum < 0)  return false;
            }

            return true;
        }

        public static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reverse = new LinkedList<int>();
            foreach(var x in list)
            {
                reverse.AddFirst(x);
            }

            return reverse;
        }

        public static List<int> MostFrequentElementsInAList(List<int> list)
        {
            Dictionary<int, int> frequentElements = new Dictionary<int, int>();
            foreach(var x in list)
            {
                if(frequentElements.ContainsKey(x))
                {
                    frequentElements[x]++;
                }
                else
                {
                    frequentElements[x] = 1;
                }
            }

            //ordering a dictionary by its values
            var frequentElementsOrdered = frequentElements.OrderByDescending(x => x.Value).ToDictionary(entry => entry.Key, entry => entry.Value);

            List<int> frequentElementsList = frequentElementsOrdered.Keys.ToList();

            return frequentElementsList;
        }

        public static Dictionary<char,List<string>> ListToDictionary(List<string> list)
        {
            Dictionary<char,List<string>> result = list.
                GroupBy(word => word[0]).
                ToDictionary(group => group.Key, group => group.ToList());

            return result;
        }

        public static List<int> RemoveOddNumbers(List<int> list)
        {
            list.RemoveAll(x => (x%2 == 0));
            return list;
        }
    }
}