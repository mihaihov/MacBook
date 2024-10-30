using System.Runtime.Serialization;
using System;

namespace HelloWorld.Exceptions {
    public class CustomException : Exception
    {
        public CustomException()
        {
            
        }

        public CustomException(string message) : base(message)
        {
            
        }

        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}