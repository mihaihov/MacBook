using ConsoleDatabase.Entities;
using ConsoleDatabase.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDatabase.Repositories
{
    public class ProductRepository : BaseRepository<Product> , IProductRepository
    {
        public ProductRepository(ApplicationDbContext _context) : base (_context)
        {
        }

        public IQueryable<Product>? GetWherePriceIsGreaterThan10AndEndsInLetterA()
        {
            IQueryable<Product>? result = _context.Products?.Where(p => p.Price > 10 && p.ProductName.EndsWith("e"));
            return result;
        }
    }

    public static class RegisterProductRepository
    {
        public static IServiceCollection RegisterProductRepositoryDI(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository,ProductRepository>();
            return services;
        }
    }
}