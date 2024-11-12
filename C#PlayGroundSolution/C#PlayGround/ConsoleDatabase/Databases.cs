using Microsoft.EntityFrameworkCore;
using ConsoleDatabase.Entities;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;


namespace ConsoleDatabase
{
    public class Databases : IDisposable, IAsyncDisposable
    {
        public readonly ApplicationDbContext _context;
        public Databases(string connectionString = "Server=tcp:sqlmachine.database.windows.net,1433;Initial Catalog=PlayGroundDb;Persist Security Info=False;User ID=mihaihov;Password=Fwmykigi96@@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;") 
        {
            DbContextOptionsBuilder<ApplicationDbContext> myOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            myOptionsBuilder.UseSqlServer(connectionString);

            _context = new ApplicationDbContext(myOptionsBuilder.Options);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            if(_context != null)
            {
                await _context.DisposeAsync();
            }
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }

        //public ApplicationDbContext() : base(new DbContextOptionsBuilder<ApplicationDbContext>()
            //.UseSqlServer("Server=tcp:sqlmachine.database.windows.net,1433;Initial Catalog=PlayGroundDb;Persist Security Info=False;User ID=mihaihov;Password=Fwmykigi96@@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;").Options){ }


        public DbSet<Order>? Orders {get;set;}
        public DbSet<OrderItem>? OrderItems {get;set;}
        public DbSet<Product>? Products {get;set;}
        public DbSet<Profile>? Profiles {get;set;}
        public DbSet<User>? Users {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //SeedDb(modelBuilder);

            //modelBuilder.ApplyConfiguration(new FluentAPI());
            modelBuilder.Entity<User>().ToTable("AppUsers");
        }

        private void SeedDb(ModelBuilder modelBuilder)
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

    //this is used by EF Core at design time to create migration, update database etc.
    // the other option is to implement a parameterless constructor which is done in the ApplicationDbcontext.
    // In a WebApi project, EF Core is using the di container which knows how to instantiate the dbcontext.
    // However in a console app like this, there is no di container so EF Core does not know how to create DbContext during
    // design time.
    // public class DesignTimeDbCreation : IDesignTimeDbContextFactory<ApplicationDbContext>
    // {
    //     public ApplicationDbContext CreateDbContext(string[] args)
    //     {
    //         DbContextOptionsBuilder<ApplicationDbContext> contextBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
    //         contextBuilder.UseSqlServer("Server=tcp:sqlmachine.database.windows.net,1433;Initial Catalog=PlayGroundDb;Persist Security Info=False;User ID=mihaihov;Password=Fwmykigi96@@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    //         return new ApplicationDbContext(contextBuilder.Options);
    //     }
    // }
}