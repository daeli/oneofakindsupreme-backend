using Microsoft.EntityFrameworkCore;
using OneOfAKindSupreme.Backend.Core.Interfaces.Repository;

namespace OneOfAKindSupreme.Backend.Infrastructure.Data.EF
{
    public class WriteRepository<T> : IWriteRepository<T> where T: class
    {
        private readonly DbContext dbContext;
        public WriteRepository(DataContext dataContext) 
        { 
            dbContext = dataContext;
        }
        public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            dbContext.Set<T>().Add(entity);

            await SaveChangesAsync(cancellationToken);

            return entity;
        }

        public async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            dbContext.Set<T>().Remove(entity);

            await SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            dbContext.Set<T>().Update(entity);

            await SaveChangesAsync(cancellationToken);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await dbContext.SaveChangesAsync(cancellationToken);
        }        
    }
}
