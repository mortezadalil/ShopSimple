            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class CustomerdemographicRepository : Repository<CustomerDemographic>, ICustomerdemographicRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public CustomerdemographicRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ICustomerdemographicRepository.cs file
}
