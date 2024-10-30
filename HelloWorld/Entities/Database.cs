using HelloWorld.Interfaces;

namespace HelloWorld.Entities {
    public class Database : IWrite {

        public void GetConnectionString() {
            Console.WriteLine("The connection string of the db is this");
        }
        public void Write()
        {
            Console.WriteLine("Writing to database.");
        }
    }
}