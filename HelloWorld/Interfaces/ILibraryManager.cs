using HelloWorld.Entities;

namespace HelloWorld.Interfaces
{
    public interface ILibraryManager {
        public void AddBook(Book b);

        public void DismissBook(Book b);

        public Library CreateLibrary();    }
}