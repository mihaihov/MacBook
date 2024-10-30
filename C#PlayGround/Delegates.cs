using System.Text;
using System;

public static class Delegates
{
    public delegate int MyDelegate(int x, int y);
    public delegate void StringProcessor(string myString);
    public static void DelegatesMain()
    {
        MyDelegate op1 = Add;
        ExecuteOperations(3, 4, op1);

        Action<int> op2 = IsEven;
        op2(3); op2(4); op2(1391);

        Func<int, int, double> op3 = GetAverage;
        System.Console.WriteLine(op3(4, 9));

        Predicate<string> beginsWithA = x => x.StartsWith('A');
        List<string> words = new() { "Animal", "Dog", "Bee", "Alphabet", "Elephant" };
        var result = words.Where(w => beginsWithA(w)).ToList();
        foreach (string i in result)
        {
            System.Console.WriteLine(i);
        }

        Func<int, int> op4 = x =>
        {
            int res = 1;
            for (int i = 1; i <= x; i++)
                res *= i;
            return res;
        };

        System.Console.WriteLine(op4(5));
        System.Console.WriteLine(op4(10));

        StringProcessor op5 = ConvertToLowercase;
        op5 += ConvertToUppercase;
        op5 += Reverse;
        op5("PrImE nUmBeR");

        List<int> numbers = new() { 12, 14, 1, 13, 19, 18, 17, 16, 15, 120, 121, 122 };
        var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
        ShowCollection(evenNumbers);

        Func<int, bool> op6 = delegate (int x) { return x > 10; };
        numbers = numbers.Where(x => op6(x)).ToList();
        ShowCollection(numbers);
        int sum = numbers.Sum();
        System.Console.WriteLine(sum);

        Action<string> op7 = (result) => System.Console.WriteLine($"String hashed successfully - {result} ! Encryption process begins...");
        LongRunningOperations(new string[] { "abc", "def", "jkl" }, op7);

        CacheItem firstElement = new("firstElementUrl", "firstElementContent", DateTime.Now);
        CacheItem secondElement = new("secondElementUrl", "secondElementContent", DateTime.Now);
        Hash(firstElement, i => i.url, i => i.content);

    }
    public static void Hash<T>(T input, params Func<T, string>[] selector)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var select in selector)
        {
            sb.Append(select(input));
        }

        System.Console.WriteLine(sb.ToString());
    }

    public record CacheItem(string url, string content, DateTime timeStamp);

    public static void LongRunningOperations(string[] words, Action<string> op7)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Operations in progress. Please wait...");

        StringBuilder sb = new StringBuilder();
        foreach (string s in words)
        {
            sb.Append(s);
        }
        //Thread.Sleep(3000);

        System.Console.WriteLine("Operation completed successfully");
        op7(sb.ToString());
    }

    public static void ShowCollection<T>(IEnumerable<T> collection)
    {
        foreach (T i in collection)
        {
            System.Console.WriteLine(i);
        }
    }

    public static void ExecuteOperations(int x, int y, MyDelegate op)
    {
        System.Console.WriteLine(op(x, y));
        op = Multiply;
        System.Console.WriteLine(op(x, y));
    }

    public static void ConvertToLowercase(string myString)
    {
        System.Console.WriteLine(myString.ToLower());
    }

    public static void ConvertToUppercase(string myString)
    {
        System.Console.WriteLine(myString.ToUpper());
    }

    public static void Reverse(string myString)
    {
        System.Console.WriteLine(myString.ToCharArray().Reverse().ToArray());
    }

    public static double GetAverage(int x, int y)
    {
        return (double)(x + y) / 2;
    }

    public static void Square(int x)
    {
        System.Console.WriteLine($"{x} squared is {x * x}");
    }

    public static void Double(int x)
    {
        System.Console.WriteLine($"The double of {x} is {2 * x}");
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }

    public static int GetCube(int x)
    {
        return x * x * x;
    }

    public static void IsEven(int x)
    {
        if (x % 2 == 0)
            System.Console.WriteLine("The number is even.");
        else
            System.Console.WriteLine("The number is odd.");
    }

    public static bool AreBothNumbersEven(int x, int y)
    {
        return (x % 2 == 0 && y % 2 == 0);
    }
}