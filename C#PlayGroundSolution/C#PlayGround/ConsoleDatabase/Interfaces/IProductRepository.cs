using ConsoleDatabase.Entities;

namespace ConsoleDatabase.Interfaces
{
    public interface IProductRepository
    {
        public IQueryable<Product>? GetWherePriceIsGreaterThan10AndEndsInLetterA();
    }
}