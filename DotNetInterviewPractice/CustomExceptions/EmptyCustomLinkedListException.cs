namespace CustomExceptions
{
    public class EmptyCustomLinkedListException : Exception
    {
        public EmptyCustomLinkedListException()
        {
        }

        public EmptyCustomLinkedListException(string? message): base(message)
        {
            
        }

        public EmptyCustomLinkedListException(string? message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}