using Microsoft.EntityFrameworkCore;
using OneOfAKindSupreme.Backend.Core.Interfaces.Repository;

namespace OneOfAKindSupreme.Backend.Infrastructure.Data.EF
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        private readonly DbContext dbContext;
        public ReadRepository(DataContext dataContext) 
        { 
            dbContext = dataContext;
        }
        public async Task<T?> GetByIdAsync<TId>(TId id, CancellationToken cancellationToken = default) where TId : notnull
        {
            return await dbContext.Set<T>().FindAsync([id], cancellationToken);
        }

        public async Task<List<T>> ListAsync(CancellationToken cancellationToken = default)
        {
            return await dbContext.Set<T>().ToListAsync(cancellationToken);
        }
    }
}
