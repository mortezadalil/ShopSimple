            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public CustomerRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ICustomerRepository.cs file
}
