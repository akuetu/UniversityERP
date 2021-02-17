using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Enrollment.Infrastructure.Data.Context;
using Enrollment.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Enrollment.Infrastructure.Data.Base
{
   
        public class BaseRepository<T>: IRepository<T> where T : class
        {
            protected readonly EnrollmentContext DbContext;

            public BaseRepository(EnrollmentContext dbContext)
            {
                DbContext = dbContext;
            }

            public virtual async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default)
            {
                var keyValues = new object[] { id };
                return await DbContext.Set<T>().FindAsync(keyValues, cancellationToken);
            }

            public async Task<IReadOnlyList<T>> ListAllAsync(CancellationToken cancellationToken = default)
            {
                return await DbContext.Set<T>().ToListAsync(cancellationToken);
            }

            public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
            {
                var specificationResult = ApplySpecification(spec);
                return await specificationResult.ToListAsync(cancellationToken);
            }

            public async Task<int> CountAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
            {
                var specificationResult = ApplySpecification(spec);
                return await specificationResult.CountAsync(cancellationToken);
            }

            public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
            {
                await DbContext.Set<T>().AddAsync(entity);
                await DbContext.SaveChangesAsync(cancellationToken);

                return entity;
            }

            public async Task<int> UpdateAsync(T entity, CancellationToken cancellationToken = default)
            {
                DbContext.Entry(entity).State = EntityState.Modified;
               return  await DbContext.SaveChangesAsync(cancellationToken);
            }

            public async Task<int> DeleteAsync(T entity, CancellationToken cancellationToken = default)
            {
                DbContext.Set<T>().Remove(entity);
               return await DbContext.SaveChangesAsync(cancellationToken);
            }

            public async Task<T> FirstAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
            {
                var specificationResult = ApplySpecification(spec);
                return await specificationResult.FirstAsync(cancellationToken);
            }

            public async Task<T> FirstOrDefaultAsync(ISpecification<T> spec, CancellationToken cancellationToken = default)
            {
                var specificationResult = ApplySpecification(spec);
                return await specificationResult.FirstOrDefaultAsync(cancellationToken);
            }

            private IQueryable<T> ApplySpecification(ISpecification<T> spec)
            {
                var evaluator = new SpecificationEvaluator<T>();
                return evaluator.GetQuery(DbContext.Set<T>().AsQueryable(), spec);
            }

        }
}

