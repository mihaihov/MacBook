using System.Runtime.Serialization;

namespace CustomExceptions {
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
            
        }

        public NegativeNumberException(string? message) : base(message)
        {
            
        }

        public NegativeNumberException(string? message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}