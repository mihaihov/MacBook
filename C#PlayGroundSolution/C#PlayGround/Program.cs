using LeetCode;
using ConsoleDatabase;
using ConsoleDatabase.Repositories;
using ConsoleDatabase.Entities;

namespace PlayGround
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Delegates.DelegatesMain();
            using(Databases dbTest = new Databases("Server=tcp:sqlmachine.database.windows.net,1433;Initial Catalog=PlayGroundDb;Persist Security Info=False;User ID=mihaihov;Password=Fwmykigi96@@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                BaseRepository<User> br = new BaseRepository<User>(dbTest._context);
                var result = await br.GetAllAsync();
                foreach(var i in result)
                {
                    Console.WriteLine(i.UserName);
                }
            }
        }
    }
}