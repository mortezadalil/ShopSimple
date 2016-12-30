
using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class RegionRepository : Repository<Region>, IRegionRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public RegionRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IRegionRepository.cs file
}
