            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class ShipperRepository : Repository<Shipper>, IShipperRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public ShipperRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IShipperRepository.cs file
}
