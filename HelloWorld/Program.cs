

using HelloWorld.Entities;

namespace HelloWorld {
    public class Program {
        public static void Main(string[] args) {
            //LINQExercises();
            try {
                DivideByZero(2,0);
            }
            catch(Exception ex) {
                Console.WriteLine($"Main: {ex.Message}");
            }
            //DivideByZero(2,0);
        }

        public static int DivideByZero(int n, int m){
            try {
                return n/m;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Divide by zero: {ex.Message}");
                throw ex;
            }
        }

        public static void LINQExercises() {
            List<int> numbers = new List<int> {23,31,45,161,243,21,45,123,5592,2249,21,0, -12,-1292,12482,2910};
            List<string> names = new List<string>{"Ana","Maria", "Ioana", "Dan", "Andrei", "Mihai", "Alina"};
            List<Employee> employees = new List<Employee>{
                new Employee {Id = 1, Name = "John", Department="IT"},
                new Employee {Id = 1, Name = "Alina", Department="IT"},
                new Employee {Id = 1, Name = "Andreea", Department="IT"},
                new Employee {Id = 1, Name = "Dana", Department="IT"},
                new Employee {Id = 1, Name = "Mihai", Department="Finance"},
                new Employee {Id = 1, Name = "George", Department="Finance"},
                new Employee {Id = 1, Name = "Diana", Department="Marketing"},
                new Employee {Id = 1, Name = "Iuli", Department="Marketing"},
                new Employee {Id = 1, Name = "Ileana", Department="Sales"}
            };

            // var result = numbers.Where(x => x%2 == 0).OrderBy(x => x);
            // ShowResult(result);

            // var result = names.Where(n => n.StartsWith("A")).Select(n => n.ToUpper());
            // ShowResult(result);

            // var result = employees.GroupBy(x => x.Department).Select(g => new {Department = g.Key, Count = g.Count()});
            // foreach(var x in result)
            // {
            //     Console.WriteLine($"Department: {x.Department}, Count: {x.Count}");
            // }

            List<Course> courses = new List<Course>() {
                new Course {Id = 1, CourseName = "Mathematics"},
                new Course {Id = 2, CourseName = "Computer Science"},
                new Course {Id = 3, CourseName = "Literature"},
                new Course {Id = 4, CourseName = "Geography"},
            };

            List<Student> students = new List<Student>() {
                new Student {Id = 1, Name = "Alina", CourseId = 1},
                new Student {Id = 2, Name = "Andreea", CourseId = 1},
                new Student {Id = 3, Name = "Dana", CourseId = 2},
                new Student {Id = 4, Name = "Marian", CourseId = 2},
                new Student {Id = 5, Name = "George", CourseId = 3},
                new Student {Id = 6, Name = "Mihai", CourseId = 3},
                new Student {Id = 7, Name = "Dan", CourseId = 4},
                new Student {Id = 8, Name = "Ilie", CourseId = 4},
                new Student {Id = 9, Name = "Ioana", CourseId = 1},
                new Student {Id = 10, Name = "Denisa", CourseId = 2},
            };

            // var result = students.Join(courses, student => student.CourseId, course => course.Id, (student,course) => new {student.Name, course.CourseName});
            // foreach(var x in result){
            //     Console.WriteLine($"Student: {x.Name}, Course: {x.CourseName}");
            // }

            List<Product> products = new List<Product>() {
                new Product {Id = 1, Name = "KitKat", Price = 39.99M},
                new Product {Id = 2, Name = "Lion", Price = 29.99M},
                new Product {Id = 3, Name = "Mars", Price = 19.99M},
                new Product {Id = 4, Name = "Twix", Price = 49.99M},
                new Product {Id = 5, Name = "Milka", Price =59.99M},
                new Product {Id = 6, Name = "Oreo", Price = 69.99M},
                new Product {Id = 7, Name = "Doritos", Price = 79.99M},
                new Product {Id = 8, Name = "ChioCips", Price = 89.99M},
                new Product {Id = 9, Name = "Lays", Price = 99.99M}
            };
            // var sum = products.Sum(p => p.Price);
            // var average = products.Average(p => p.Price);
            // var min = products.Min(p => p.Price);
            // var max = products.Max(p => p.Price);
            // Console.WriteLine($"Tota: {sum}, Average: {average}, Min: {min}, Max: {max}");

            List<Book> books = new List<Book>() {
                new Book {Id = 1, Name = "Stapanul Inelelor", Author = "JRR Tolkien", Year = 2001},
                new Book {Id = 2, Name = "A Song of Ice and Fire", Author = "GRR Martin", Year = 1994},
                new Book {Id = 3, Name = "A feast for the crows", Author = "GRR Martin", Year = 2003},
                new Book {Id = 4, Name = "A Winds of Winter", Author = "GRR Martin", Year = 2006},
                new Book {Id = 5, Name = "A dance of dragons", Author = "GRR Martin", Year = 1995}
            };

            var result = books.Where(book => book.Author == "JRR Tolkien" && book.Year > 2000);
            foreach (var x in result){
                Console.WriteLine($"Name: {x.Name}, Auther: {x.Author}");
            }
        }

        public static void ShowResult(IEnumerable<string> numbers){
            foreach(var number in numbers ) {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine();
        }
    }
}


