using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.UnifOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqliteContext _context;
        private bool disposed = false;
        private Dictionary<Type, object> _repositories;

        /// <summary>
        /// Initializes a new instance of the UnitOfWork<TContext>.
        /// </summary>
        /// <param name="context">The context.</param>
        public UnitOfWork(SqliteContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public SqliteContext DbContext => _context;

        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories == null)
            {
                _repositories = new Dictionary<Type, object>();
            }

            var type = typeof(TEntity);
            if (!_repositories.ContainsKey(type))
            {
                _repositories[type] = new GenericRepository<TEntity>(_context);
            }

            return (IGenericRepository<TEntity>)_repositories[type];
        }


        public int ExecuteSqlCommand(
            string sql,
            params object[] parameters
        ) => _context.Database.ExecuteSqlRaw(sql, parameters);

        public IQueryable<TEntity> FromSql<TEntity>(
            string sql,
            params object[] parameters
        ) where TEntity : class => _context.Set<TEntity>().FromSqlRaw(sql, parameters);

        public int Save()
        {
            return _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _repositories.Clear();
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
