using HelloWorld.Entities;
using HelloWorld.Interfaces;

namespace HelloWorld.Infrastructure {
    public class LibraryManager : ILibraryManager
    {
        private readonly Library Library;
        public List<Member> Members { get; set; }

        public LibraryManager()
        {
            if(Library == null) Library = CreateLibrary();
            Members = new List<Member>();
        }

        public void AddBook(Book b)
        {
            Library.Books.Add(b);
        }

        public Library CreateLibrary()
        {
            return new Library();
        }

        public void DismissBook(Book b)
        {
            Library.Books.Remove(b);
        }
    }
}