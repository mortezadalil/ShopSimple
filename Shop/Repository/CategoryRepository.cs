            using System.Collections.Generic;
using System.Linq;			
using Shop.Models.Northwind;
              
public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private Shop.Models.ApplicationDbContext _context;

    public CategoryRepository(Shop.Models.ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ICategoryRepository.cs file
}
