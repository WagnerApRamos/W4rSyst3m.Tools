#region Using

using System;
using System.Collections.Generic;
using System.Data.Entity;

#endregion

namespace W4rSyst3m.Tools.TestUtilities.Common
{
    /// <summary>
    /// Context manager to add/restore the database on this context
    /// </summary>
    /// <typeparam name="C">It has to be a DbContext</typeparam>
    public class DbContextManager<C> : IDisposable
        where C : DbContext
    {
        private readonly C _dbContext;
        private readonly List<object> _entities;

        /// <summary>
        /// Indicates if the class has been disposed.
        /// </summary>
        public bool IsDisposed { get; private set; }

        public DbContextManager(C dbContext)
        {
            _dbContext = dbContext;
            _entities = new List<object>();
        }

        /// <summary>
        /// Add new entity into context
        /// </summary>
        /// <typeparam name="TEntity">A class that represents a table in the context</typeparam>
        /// <param name="entity">object to be added into context</param>
        public void Add<TEntity>(TEntity entity)
            where TEntity : class
        {
            _entities.Add(entity);
            _dbContext.Set<TEntity>().Add(entity);
        }

        /// <summary>
        /// Add a collection into context
        /// </summary>
        /// <typeparam name="TEntity">A class that represents a table in the context</typeparam>
        /// <param name="entities">A collection of object to be added into context</param>
        public void Add<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class
        {
            _entities.AddRange(entities);
            _dbContext.Set<TEntity>().AddRange(entities);
        }

        /// <summary>
        /// Save the objects into database
        /// </summary>
        public void SaveContext()
        {
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Remove all added objects into context
        /// </summary>
        public void Restore()
        {
            foreach (var entity in _entities)
            {
                _dbContext.Set(entity.GetType()).Remove(entity);
            }

            SaveContext();
        }

        /// <summary>
        /// realise object and its dependences from mempry
        /// </summary>
        public void Dispose()
        {
            if (IsDisposed) return;

            _dbContext.Dispose();
            _entities.Clear();
            GC.SuppressFinalize(this);
            IsDisposed = true;
        }
    }
}
