using Shop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Services
{
    public interface IOrderService
    {
        OrderDTO Get(string lastName);
        OrderDTO Get(Guid id);
        IEnumerable<OrderDTO> GetAll();
        void Create(string firstName, string lastName, string phoneNumber,
            string email, string orderStatus, string shipmentStatus);
        void Delete(Guid id);
    }
}
