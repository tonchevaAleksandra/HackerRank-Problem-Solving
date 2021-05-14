using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HomeworkEFCore.Data.Commons
{
    public class Repository<T> : IRepository<T> where T:class
    {
        public Repository(OrdersSummaryDbContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
            this.DbSet = this.Context.Set<T>();
        }

        protected DbSet<T> DbSet { get; set; }

        protected OrdersSummaryDbContext Context { get; set; }

        public virtual IQueryable<T> All() => this.DbSet;

        public virtual IQueryable<T> AllAsNoTracking() => this.DbSet.AsNoTracking();

        public virtual Task AddAsync(T entity) => this.DbSet.AddAsync(entity).AsTask();

        public virtual void Update(T entity)
        {
            var entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public virtual void Delete(T entity) => this.DbSet.Remove(entity);

        public Task<int> SaveChangesAsync() => this.Context.SaveChangesAsync();

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context?.Dispose();
            }
        }
    }
}
