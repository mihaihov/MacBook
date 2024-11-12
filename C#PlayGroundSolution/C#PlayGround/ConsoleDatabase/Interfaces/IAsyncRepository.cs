namespace ConsoleDatabase.Interfaces
{
    public interface IAsyncRepository<T> where T : class
    {
        public Task AddAsync(T Entity);
        public Task UpdateAsync(T Entity);
        public Task<T?> GetById(int Id);

        public Task<IReadOnlyList<T>> GetAllAsync();
    }
}