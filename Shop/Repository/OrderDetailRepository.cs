            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class OrderDetailRepository : Repository<Order_Detail>, IOrderDetailRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public OrderDetailRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IOrderDetailRepository.cs file
}
