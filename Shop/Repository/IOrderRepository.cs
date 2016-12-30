using System.Collections.Generic;
using Shop.Models.Northwind;

public interface IOrderRepository : IRepository<Order>
{
    //Add any additional repository methods other than the generic ones (GetAll, GetById, Delete, Add)
}
