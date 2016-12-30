            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class TerritoryRepository : Repository<Territory>, ITerritoryRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public TerritoryRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ITerritoryRepository.cs file
}
