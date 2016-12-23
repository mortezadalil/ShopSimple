#region using

using System;
using System.Threading;
using System.Threading.Tasks;

#endregion

namespace Shop.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        #region Properties

        IProductRepository ProductRepository { get; }

        #endregion

        #region Methods

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        #endregion
    }
}