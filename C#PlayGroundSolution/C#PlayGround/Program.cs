using LeetCode;
using ConsoleDatabase;
using ConsoleDatabase.Repositories;
using ConsoleDatabase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ConsoleDatabase.Interfaces;

namespace PlayGround
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Delegates.DelegatesMain();

            ServiceCollection myServiceCollection = new ServiceCollection();
            ConfigureServiceCollection(myServiceCollection);
            var myServiceCollectionBuilder = myServiceCollection.BuildServiceProvider();

            var br = myServiceCollectionBuilder.GetRequiredService<IAsyncRepository<User>>();
            var result = await br.GetAllAsync();
            foreach(var r in result)
            {
                Console.WriteLine(r.UserName);
            }

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