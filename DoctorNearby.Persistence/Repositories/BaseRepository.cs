using Azure;
using DoctorNearby.Persistence.Interfaces;
using DoctorNearby.Persistence.Models.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;


namespace DoctorNearby.Persistence.Repositories
{
    public class BaseRepository<T>(DataContext context) : IBaseRepository<T>
        where T : BaseEntity
    {
        public async Task CreateAsync(T entity, CancellationToken cancellationToken)
        {
            await context.AddAsync(entity, cancellationToken);
            await context.SaveChangesAsync();

        }

        public async Task DeleteAsync(T entity, CancellationToken cancellationToken)
        {
            context.Remove(entity);
            await context.SaveChangesAsync(cancellationToken);


        }

        public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await context
                .Set<T>()
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        }

        public async Task UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync(cancellationToken);
        }

        public async Task<IQueryable<T>> GetByPage(int page, int pageSize)
        {
            return context.Set<T>()
                .AsNoTracking()
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }


    }
}
