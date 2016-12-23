using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Models;
using Shop.Repository;

namespace Shop.Services
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public List<Product> GetTopProductsByCost(int count)
        {
            return Set.OrderByDescending(x => x.Cost).Take(count).ToList();
        }

        public Tuple<Product, int, string> Update(Product entity)
        {
            throw new NotImplementedException();
        }


    }
}