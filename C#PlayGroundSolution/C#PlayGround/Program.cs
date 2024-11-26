using LeetCode;
using ConsoleDatabase;
using ConsoleDatabase.Repositories;
using ConsoleDatabase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ConsoleDatabase.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace PlayGround
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        private static void DebugMigration(ServiceProvider myServiceCollectionBuilder)
        {
            using(var scope = myServiceCollectionBuilder.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                var migration = context.GetService<Microsoft.EntityFrameworkCore.Migrations.IMigrator>();
                migration.Migrate("RenameUsersTable");
            }
        }

        private static ServiceProvider RegisterServices()
        {
            ServiceCollection myServiceCollection = DIContainer.Instance.GetDIContainer();
            ConfigureServiceCollection(myServiceCollection);
            RegisterProductRepository.RegisterProductRepositoryDI(myServiceCollection);
            var myServiceCollectionBuilder = myServiceCollection.BuildServiceProvider();
            return myServiceCollectionBuilder;
        }

        public static void ConfigureServiceCollection(ServiceCollection myServiceCollection)
        {
            //register ApplicationdbContext.
            myServiceCollection.AddScoped<ApplicationDbContext>(provider => {
                var options = new DbContextOptionsBuilder<ApplicationDbContext>();
                options.UseSqlServer("Server=tcp:sqlmachine.database.windows.net,1433;Initial Catalog=PlayGroundDb;Persist Security Info=False;User ID=mihaihov;Password=Fwmykigi96@@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                return new ApplicationDbContext(options.Options);
            });

            //register the base repository
            myServiceCollection.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
        }
    }
}