#region using

using Shop.Models;
using Shop.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

#endregion

namespace Shop.Services
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _set;
        protected ApplicationDbContext Context;

        internal Repository(ApplicationDbContext context)
        {
            Context = context;
        }

        protected DbSet<TEntity> Set => _set ?? (_set = Context.Set<TEntity>());

        public int CountAll()
        {
            return Set.Count();

        }

        public List<TEntity> GetAll()
        {
            return Set.ToList();
        }

        public TEntity FindById(object id)
        {
            return Set.Find(id);
        }

        public Tuple<TEntity, int, string> Add(TEntity entity)
        {
            TEntity newEntity;
            int status;
            string message;

            try
            {
                newEntity = Set.Add(entity);
                status = 1;
                message = "Ok";

            }
            catch (Exception ex)
            {
                newEntity = null;
                status = 0;
                message = ex.Message;
            }

            return new Tuple<TEntity, int, string>(newEntity, status, message);
        }

        public Tuple<TEntity, int, string> Delete(TEntity entity)
        {
            TEntity newEntity;
            int status;
            string message;

            try
            {
                newEntity = Set.Remove(entity);
                status = 1;
                message = "Ok";

            }
            catch (Exception ex)
            {
                newEntity = null;
                status = 0;
                message = ex.Message;
            }

            return new Tuple<TEntity, int, string>(newEntity, status, message);
        }
    }
}