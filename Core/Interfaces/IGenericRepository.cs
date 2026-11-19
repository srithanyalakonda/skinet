using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> ListAllAsync() ;
        Task<T?> GetByIdAsync(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        Task<bool> SaveChangesAsync();
        bool Exists(int id) ;

        Task<T?> GetEntityWithSpec(ISpecification<T> spec);

        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);

        Task<TResult?> GetEntityWithSpec<TResult>(ISpecification<T, TResult> spec);

        Task<IReadOnlyList<TResult>> ListAsync<TResult>(ISpecification<T, TResult> spec);

    }
}
