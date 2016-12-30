            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class OrderRepository : Repository<Order>, IOrderRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public OrderRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IOrderRepository.cs file
}
