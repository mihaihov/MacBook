using CustomExceptions;

namespace ErrorHandlingExercises
{
    public static class ErrorHandlingExercises
    {
        public static void DivideByZero(int x, int y)
        {
            if(y == 0)
                throw new DivideByZeroException("Divider cannot be 0");
            Console.WriteLine(x/y);
        }

        public static string ReadFileContent(string fileName)
        {
            try
            {
                string result = File.ReadAllText(fileName);
                return result;
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }

        public static int ParseInt(string input, int defaultValue)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(input);
                return result;
            }
            catch (Exception ex)
            {
                result = defaultValue;
                return result;
            }
        }

        public static void SquareRoot(int x)
        {
            if(x<0)
                throw new NegativeNumberException();
            Console.WriteLine(Math.Sqrt(x));
        }
    }
}