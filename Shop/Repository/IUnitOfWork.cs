            using System;

public interface IUnitOfWork : IDisposable
{
    IRegionRepository Regions { get; }
    ICategoryRepository Categorys { get; }
    IShipperRepository Shippers { get; }
    ITerritoryRepository Territorys { get; }
    IEmployeeRepository Employees { get; }
    IProductRepository Products { get; }
    IOrderRepository Orders { get; }
    ICustomerdemographicRepository Customerdemographics { get; }
    ICustomerRepository Customers { get; }
    ISupplierRepository Suppliers { get; }
    IInvoiceRepository Invoices { get; }
    IOrderDetailRepository OrderDetails { get; }
    IApplicationuserRepository Applicationusers { get; }
    IApplicationroleRepository Applicationroles { get; }
    void Save();
}
