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
        public static async Task Main(string[] args)
        {
            //Delegates.DelegatesMain();

            ServiceCollection myServiceCollection = new ServiceCollection();
            ConfigureServiceCollection(myServiceCollection);
            RegisterProductRepository.RegisterProductRepositoryDI(myServiceCollection);
            var myServiceCollectionBuilder = myServiceCollection.BuildServiceProvider();

            //this code is used to debug a migration.
            using(var scope = myServiceCollectionBuilder.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                var migration = context.GetService<Microsoft.EntityFrameworkCore.Migrations.IMigrator>();
                migration.Migrate("RenameUsersTable");
            }
            // var userRepository = myServiceCollectionBuilder.GetRequiredService<IAsyncRepository<User>>();
            // var users = await userRepository.GetAllAsync();


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