using Microsoft.EntityFrameworkCore;
using ConsoleDatabase.Entities;

namespace ConsoleDatabase
{
    public class Databases
    {
        private readonly ApplicationDbContext _context;
        public Databases(string connectionString) 
        {
            DbContextOptionsBuilder<ApplicationDbContext> myOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            myOptionsBuilder.UseSqlServer(connectionString);

            _context = new ApplicationDbContext(myOptionsBuilder.Options);
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }

        public DbSet<Order>? Orders {get;set;}
        public DbSet<OrderItem>? OrderItems {get;set;}
        public DbSet<Product>? Products {get;set;}
        public DbSet<Profile>? Profiles {get;set;}
        public DbSet<User>? Users {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "Mihai", Email = "raducumihaicristian@gmail.com" },
                new User { UserId = 2, UserName = "Dana", Email = "danaarvinti@gmail.com"},
                new User { UserId = 3, UserName = "Irina", Email = "irinaraducu@gmail.com" }
            );


            modelBuilder.Entity<Profile>().HasData(
                new Profile { ProfileId = 1, UserId = 1, FirstName = "Mihai", LastName = "Raducu" },
                new Profile { ProfileId = 2, UserId = 2, FirstName = "Dana", LastName = "Arvinti" },
                new Profile { ProfileId = 3, UserId = 3, FirstName = "Irina", LastName = "Raducu" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Apa", Price = 7.99m },
                new Product { ProductId = 2, ProductName = "Lapte", Price = 10.99m },
                new Product { ProductId = 3, ProductName = "Suc", Price = 17.99m },
                new Product { ProductId = 4, ProductName = "Bere", Price = 12.99m },
                new Product { ProductId = 5, ProductName = "Gin", Price = 57.99m }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, UserId = 1, OrderDate = DateTime.Now.AddMinutes(-30)},
                new Order { OrderId = 2, UserId = 2, OrderDate = DateTime.Now.AddMinutes(-45)},
                new Order { OrderId = 3, UserId = 3, OrderDate = DateTime.Now.AddMinutes(-120)},
                new Order { OrderId = 4, UserId = 1, OrderDate = DateTime.Now.AddMinutes(-130)}
            );

            modelBuilder.Entity<OrderItem>().HasData (
                new OrderItem {OrderItemId = 1, OrderId = 1, ProductId = 1},
                new OrderItem {OrderItemId = 2, OrderId = 2, ProductId = 2},
                new OrderItem {OrderItemId = 3, OrderId = 3, ProductId = 3},
                new OrderItem {OrderItemId = 4, OrderId = 4, ProductId = 4},
                new OrderItem {OrderItemId = 5, OrderId = 1, ProductId = 5},
                new OrderItem {OrderItemId = 6, OrderId = 2, ProductId = 1},
                new OrderItem {OrderItemId = 7, OrderId = 3, ProductId = 2},
                new OrderItem {OrderItemId = 8, OrderId = 4, ProductId = 3},
                new OrderItem {OrderItemId = 9, OrderId = 1, ProductId = 4},
                new OrderItem {OrderItemId = 10, OrderId = 2, ProductId = 5},
                new OrderItem {OrderItemId = 11, OrderId = 3, ProductId = 1},
                new OrderItem {OrderItemId = 12, OrderId = 4, ProductId = 2},
                new OrderItem {OrderItemId = 13, OrderId = 1, ProductId = 3},
                new OrderItem {OrderItemId = 14, OrderId = 2, ProductId = 4},
                new OrderItem {OrderItemId = 15, OrderId = 3, ProductId = 5}
            );
        }

    }
}