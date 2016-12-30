using System;
using Shop.Models.Northwind;

public sealed class UnitOfWork : IUnitOfWork
{
    private Shop.Models.ApplicationDbContext _context;

    public UnitOfWork(Shop.Models.ApplicationDbContext context)
    {
        _context = context;
    }

	//Delete this default constructor if using an IoC container
	public UnitOfWork()
	{
		_context = new Shop.Models.ApplicationDbContext();
	}
	
    public IRegionRepository Regions
    {
        get { return new RegionRepository(_context); }
    }

    public ICategoryRepository Categorys
    {
        get { return new CategoryRepository(_context); }
    }

    public IShipperRepository Shippers
    {
        get { return new ShipperRepository(_context); }
    }

    public ITerritoryRepository Territorys
    {
        get { return new TerritoryRepository(_context); }
    }

    public IEmployeeRepository Employees
    {
        get { return new EmployeeRepository(_context); }
    }

    public IProductRepository Products
    {
        get { return new ProductRepository(_context); }
    }

    public IOrderRepository Orders
    {
        get { return new OrderRepository(_context); }
    }

    public ICustomerdemographicRepository Customerdemographics
    {
        get { return new CustomerdemographicRepository(_context); }
    }

    public ICustomerRepository Customers
    {
        get { return new CustomerRepository(_context); }
    }

    public ISupplierRepository Suppliers
    {
        get { return new SupplierRepository(_context); }
    }

    public IInvoiceRepository Invoices
    {
        get { return new InvoiceRepository(_context); }
    }

    public IOrderDetailRepository OrderDetails
    {
        get { return new OrderDetailRepository(_context); }
    }

    public IApplicationuserRepository Applicationusers
    {
        get { return new ApplicationuserRepository(_context); }
    }

    public IApplicationroleRepository Applicationroles
    {
        get { return new ApplicationroleRepository(_context); }
    }

    
    public void Save()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
    }
}
