using Shop.Infrastructure.Models;
using Shop.Infrastructure.Querys;
using System;
using System.Collections.Generic;

namespace Shop.Infrastructure.Services
{
    public interface IOrderService
    {
        OrderDTO Get(string lastName);
        OrderDTO Get(Guid id);
        CompleteOrderDTO GetCompleteOrder(Guid id);
        PageResult<OrderDTO> GetAll(OrderQuery query);
        void Create(string firstName, string lastName, string phoneNumber,
            string email, string orderStatus, string shipmentStatus);
        void Delete(Guid id);
    }
}
