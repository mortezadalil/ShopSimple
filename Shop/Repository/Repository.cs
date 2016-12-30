using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Shop.Models.Northwind;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DbSet<TEntity> _entities;

    protected Repository(Shop.Models.ApplicationDbContext context)
    {
        _entities = context.Set<TEntity>();
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _entities.ToList();
    }

    public TEntity GetById(int id)
    {
        return _entities.Find(id);
    }

    public void Add(TEntity entity)
    {
        _entities.Add(entity);
    }

    public void Delete(TEntity entity)
    {
        _entities.Remove(entity);
    }
}

