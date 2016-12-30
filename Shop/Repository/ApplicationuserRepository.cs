            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class ApplicationuserRepository : Repository<ApplicationUser>, IApplicationuserRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public ApplicationuserRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IApplicationuserRepository.cs file
}
