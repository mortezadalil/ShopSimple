            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class ApplicationroleRepository : Repository<ApplicationRole>, IApplicationroleRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public ApplicationroleRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IApplicationroleRepository.cs file
}
