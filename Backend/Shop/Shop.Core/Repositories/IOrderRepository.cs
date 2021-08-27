using Shop.Core.Domain;
using System;
using System.Collections.Generic;

namespace Shop.Core.Repositories
{
    public interface IOrderRepository
    {
        Order GetOrder(string lastName);
        Order GetOrder(Guid id);
        Order GetCompleteOrder(Guid id);
        IEnumerable<Order> GetAll(string searchPhrase, int PageNumber, int PageSize);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Guid id);
    }
}
