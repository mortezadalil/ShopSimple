            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public EmployeeRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IEmployeeRepository.cs file
}
