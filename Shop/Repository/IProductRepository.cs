#region using

using System;
using System.Collections.Generic;
using Shop.Models;

#endregion

namespace Shop.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetTopProductsByCost(int count);

        Tuple<Product, int, string> Update(Product entity);
    }
}