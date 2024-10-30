using CollectionsExercises;
using Entities;
using CustomCollections;
using LinqExercises;
using AsyncExercises;
using System.Net.Http.Json;

        //Remove duplicates
// List<int> numbers = new List<int>{1,2,3,1,2,2,2,3,1,4,5,4,1,2,-1,-1,-2,-2,-3,-8};
// List<int> removeDuplicatesUsingDictionaries = CollectionExercises.RemoveDuplicatesUsingDictionaries(numbers);
// List<int> removeDuplicatesUsingHashSet = CollectionExercises.RemoveDuplicatesUsingHashSet(numbers);
//DisplayCollection(removeDuplicatesUsingHashSet);

        //Counts the words in a string
// string myString = "Ursul este in camara? Unde este ursul? Ursul este in camara! Ia-l si da-l afara.";
// Dictionary<string,int> result = CollectionExercises.CountWords(myString);
// DisplayDictionary(result);

        //Adds and removes customers from a queue;
// Queue<Customer> myQueue = new Queue<Customer>();
// CollectionExercises.AddCustomerToQueue(myQueue, new Customer{Name = "Mihai", Age = 28});
// CollectionExercises.AddCustomerToQueue(myQueue, new Customer{Name = "Dana", Age = 27});
// CollectionExercises.AddCustomerToQueue(myQueue, new Customer{Name = "Irina", Age = 33});
// DisplayQueue(myQueue);
// CollectionExercises.RemoveCustomerFromQueue(myQueue);
// DisplayQueue(myQueue);
// CollectionExercises.AddCustomerToQueue(myQueue, new Customer{Name = "Florina", Age = 55});
// CollectionExercises.AddCustomerToQueue(myQueue, new Customer{Name = "Daniel", Age = 57});
// DisplayQueue(myQueue);
// Console.WriteLine(myQueue.Peek().Name);

        //Balanced Pharentesis
// Stack<char> pharentesis = new Stack<char>();
// pharentesis.Push('(');
// pharentesis.Push('(');
// pharentesis.Push('(');
// pharentesis.Push(')');
// pharentesis.Push(')');
// pharentesis.Push('(');
// pharentesis.Push(')');
// pharentesis.Push(')');
// Console.WriteLine(CollectionExercises.BalancedPharentesis(pharentesis));


        //Reverse Linked List
// LinkedList<int> list = new LinkedList<int>();
// list.AddLast(1);
// list.AddLast(2);
// list.AddLast(3);
// list.AddLast(4);
// list.AddLast(5);
// list.AddLast(6);
// list.AddLast(7);
// LinkedList<int> reversedList = CollectionExercises.ReverseLinkedList(list);
// DisplayCollection(reversedList);

        //Find top 3 frequent elements in a list by using a dictionary
// List<int> list = new List<int> {13,25,43,13,4,7,7,2,25,25,25,13,13,25,13,18,7,13,25};
// List<int> freqeuentElements = CollectionExercises.MostFrequentElementsInAList(list);
// DisplayCollection(freqeuentElements);

        //CustomCollection
// CustomCollection<int> myCollection = new CustomCollection<int>();
// myCollection.AddElement(3);
// myCollection.AddElement(5);
// myCollection.AddElement(7);
// myCollection.AddElement(9);
// myCollection.Dsiplay();

        //Convert List to Dictionary.
// List<string> list = new List<string>{"Aba", "are", "mere","mara","are","mere","mara", "are", "alune"};
// Dictionary<char, List<string>> result = CollectionExercises.ListToDictionary(list);
// DisplayDictionary2(result);

//******************************************************************************LINQ
        //filter even numbers and sort the remaining in descenting order
// List<int> list = new List<int> {21,31,-2,44,51,-12,-25,-80,91,245};
// var result = LinqExercises.LinqExercises.RemoveEvenNumbers(list);
// DisplayCollection(result);

        //Find first word which starts with letter;
// char c = 'A';
// List<string> list = new List<string> {"caine", "paine", "masa","alina","Ana"};
// var result = LinqExercises.LinqExercises.FirstWordStartingWithLetter(list,c);
// Console.WriteLine(result);

        //sum of all even numbers
// List<int> list = new List<int>{21,31,-2,44,51,-12,-25,-80,91,245};
// Console.WriteLine(LinqExercises.LinqExercises.SumOfEvenNumbers(list));

        //group strings by length
// List<string> list = new List<string> { "apple", "banana", "pear", "cherry", "kiwi", "mango", "fig", "plum" };
// LinqExercises.LinqExercises.GroupByLength(list);

        //Convert List of objects into a dictionary
// List<Customer> list = new List<Customer>{new Customer{Name = "Mihai", Age = 28}, new Customer{Name = "Dana", Age = 27} , new Customer{Name = "Irina", Age = 33}};
// LinqExercises.LinqExercises.ListToDictionary(list);

        //Top 3 longest words;
// List<string> list = new List<string>{"apple", "banana", "pear", "cherry", "kiwi", "mango", "fig", "plum"};
// LinqExercises.LinqExercises.Top3LongestWords(list);

        //Count how many words contain the letter e
// List<string> list = new List<string>{"apple", "banana", "pear", "cherry", "kiwi", "mango", "fig", "plum"};
// LinqExercises.LinqExercises.CountWordsThatContainSpecificLetter(list);

        //Flatten list of lists
// List<List<int>> list = new List<List<int>>();
// list.Add(new List<int>{1,2,3});
// list.Add(new List<int>{4,5,6});
// list.Add(new List<int>{7,8,9});
// LinqExercises.LinqExercises.FlattenLists(list);

        //Average age
// List<Customer> list = new List<Customer>{new Customer{Name = "Mihai", Age = 28}, new Customer{Name = "Dana", Age = 27} , new Customer{Name = "Irina", Age = 33}};
// LinqExercises.LinqExercises.AverageAge(list);

//******************************************************************************ERROR_HANDLING
        //HandleDivisionByZero
// ErrorHandlingExercises.ErrorHandlingExercises.DivideByZero(4,0);

        //ReadFromAFile
// var result = ErrorHandlingExercises.ErrorHandlingExercises.ReadFileContent("myFile.txt");
// Console.WriteLine(result);

        //ConvertStringToInt
// var result = ErrorHandlingExercises.ErrorHandlingExercises.ParseInt("23abc", 11);
// Console.WriteLine(result);

        //square root exception
// ErrorHandlingExercises.ErrorHandlingExercises.SquareRoot(-15);

//******************************************************************************ASYNC
        //wait 3 seconds
// string result = await AsyncExercises.AsyncExercises.ThreeSecondWait();
// Console.WriteLine(result);

        //handle multiple async operations
// string[] result = await Task.WhenAll(AsyncExercises.AsyncExercises.AsyncOper1(), AsyncExercises.AsyncExercises.AsyncOper2(), AsyncExercises.AsyncExercises.AsyncOper3());
// foreach (var resultItem in result)
// {
//     Console.WriteLine(resultItem);
// }

        //Read from file async
// string value = await AsyncExercises.AsyncExercises.ReadFromFileAsync("myFile.txt");
// Console.WriteLine(value);

        //Fetch data from web
// string response = await AsyncExercises.AsyncExercises.FetchDataAsync("https://jsonplaceholder.typicode.com/todos/1");
// Console.WriteLine(response);

        //RemoveStones_LeetCode
// int[][] myArray = new int[5][];
// myArray[0] = new int[] {0,0};
// myArray[1] = new int[] {0,2};
// myArray[2] = new int[] {1,1};
// myArray[3] = new int[] {2,0};
// myArray[4] = new int[] {2,2};
// LeetCodeExercises.LeetCodeExercises.RemoveStones(myArray);

        //longest palindrome
// Console.WriteLine(LeetCodeExercises.LeetCodeExercises.LongestPalindrome("babad"));

        // Maixmum products of word length
// string[] words = new string[5];
// words[0] = "Ana";
// words[1] = "are";
// words[2] = "mere";
// words[3] = "si";
// words[4] = "nuci";
// LeetCodeExercises.LeetCodeExercises.MaximumProductOfWordLength(words);
// Console.WriteLine(LeetCodeExercises.LeetCodeExercises.UniqueCharactersWithoutAdditionalDataStructure("mama"));
// Console.WriteLine(LeetCodeExercises.LeetCodeExercises.CheckAnagrams("god ","dog"));

        //repalce whitespaces with %20
//LeetCodeExercises.LeetCodeExercises.ReplaceWhiteSpaces("This    is a dog");
        //palindrom permutation check
//Console.WriteLine(LeetCodeExercises.LeetCodeExercises.PalindromPermutationCheck("ccaapppx"));
        //cracking the code interview 1.5/page 91
// Console.WriteLine(LeetCodeExercises.LeetCodeExercises.OneWay("pale","bake"));

        //string compression: aaaabbcccccdde -> a4b2c5d2e1
// Console.WriteLine(LeetCodeExercises.LeetCodeExercises.StringCompresion("aaaabbcccccdde"));

                //LINKED LISTS EXERCISES.
// CustomLinkedList<int> myList = new CustomLinkedList<int>();
// myList.Append(25);
// myList.Append(3);
// myList.Append(25);
// myList.Append(41);
// myList.Append(25);
// myList.Append(24);
// myList.Append(41);
// myList.Append(25);
// myList.Append(3);
// myList.Append(12);
// myList.Show();
// myList.RemoveDuplicatesUsingHashSet();
// myList.Show();
// myList.RemoveInTheMiddle(25);
// myList.Show();

                //Add two numbers represented as linked lists;
// CustomLinkedList<int> l1 = new CustomLinkedList<int>(); 
// l1.Append(2);
// //l1.Append(3);
// //l1.Append(4);
// CustomLinkedList<int> l2 = new CustomLinkedList<int>(); 
// l2.Append(2);
// l2.Append(1);
// l2.Append(9);
// l2.Append(1);
// CustomLinkedList<int> l3 = l1 + l2;
// l3.Show();

// var Mihai = new Person {FirstName = "Mihai", LastName = "Raducu", Age = 28};
// Console.WriteLine($"My name is {Mihai.FirstName} {Mihai.LastName}. I am {Mihai.Age} years old.");
// Mihai.Age = 29;
// Console.WriteLine($"My name is {Mihai.FirstName} {Mihai.LastName}. I am {Mihai.Age} years old.");

//






static void DisplayCollection<T>(IEnumerable<T> collection)
{
    foreach(var x in collection){
        Console.WriteLine(x);
    }
    Console.WriteLine();
}

static void DisplayQueue(Queue<Customer> customers)
{
    foreach(var x in customers)
    {
        Console.WriteLine(x.Name);
    }
    Console.WriteLine();
}

static void DisplayDictionary<T,U>(Dictionary<T,U> dictionary)
{
    foreach(KeyValuePair<T,U> pair in dictionary)
    {
        Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
}

static void DisplayDictionary2(Dictionary<char,List<string>> dictionary)
{
    foreach(var pair in dictionary)
    {
        Console.WriteLine($"{pair.Key}:");
        foreach(var x in pair.Value)
        {
            Console.Write(x + ", ");
        }
        Console.WriteLine();
    }
}

