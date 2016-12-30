            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public InvoiceRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IInvoiceRepository.cs file
}
