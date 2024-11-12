using ConsoleDatabase.Entities;
using ConsoleDatabase.Interfaces;

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
}