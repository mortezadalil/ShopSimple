#region using

using System;
using System.Collections.Generic;

#endregion

namespace Shop.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        int CountAll();

        List<TEntity> GetAll();

        TEntity FindById(object id);

        Tuple<TEntity, int, string> Add(TEntity entity);

        Tuple<TEntity, int, string> Delete(TEntity entity);


        //List<TEntity> Search(string colName, string searchItem);
        //Task<List<TEntity>> GetAllAsync();
        //Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
        //List<TEntity> PageAll(int skip, int take, string colName, string order);
        //Task<List<TEntity>> PageAllAsync(int skip, int take);
        //Task<List<TEntity>> PageAllAsync(CancellationToken cancellationToken, int skip, int take);
        //Task<TEntity> FindByIdAsync(object id);
        //Task<TEntity> FindByIdAsync(CancellationToken cancellationToken, object id);
        //void Update(TEntity entity);
    }
}