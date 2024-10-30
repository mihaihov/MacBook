namespace HelloWorld.Entities
{
    public class Library
    {
        public string Name { get; set; } = string.Empty;

        public List<Book> Books { get; set; } = new List<Book>();
    }
}