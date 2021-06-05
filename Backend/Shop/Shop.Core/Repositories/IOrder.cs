using Shop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface IOrder
    {
        Order GetOrder(string lastName);
        IEnumerable<Order> GetAll();
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Guid id);
    }
}
