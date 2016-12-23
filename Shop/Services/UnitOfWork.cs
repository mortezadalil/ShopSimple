#region using

using Shop.Models;
using Shop.Repository;
using System;
using System.Threading;
using System.Threading.Tasks;

#endregion

namespace Shop.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Constructors

        public UnitOfWork()
        {
            _context = new ApplicationDbContext();
        }

        #endregion

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            _productRepository = null;
            _context.Dispose();
        }

        #endregion

        #region Fields

        private IProductRepository _productRepository;
        private readonly ApplicationDbContext _context;

        #endregion

        #region IUnitOfWork Members

        public IProductRepository ProductRepository
            => _productRepository ?? (_productRepository = new ProductRepository(_context));


        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }

        #endregion
    }
}