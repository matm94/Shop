
using Shop.Core.Domain;
using Shop.Core.Repositories;
using Shop.Infrastructure.Exceptions;
using Shop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Extensions
{
    public static class OrderRepositoryExtension
    {
        public static Order GetOrderNotExists(this IOrderRepository _orderRepository, string lastName)
        {
            var order = _orderRepository.GetOrder(lastName);
            if(order != null)
            {
                throw new Exception("Order allready exist");
            }

            return order;
        }

        public static Order GetOrderExists(this IOrderRepository _orderRepository, string lastName)
        {
            var order = _orderRepository.GetOrder(lastName);
            if (order == null)
            {
                throw new NotFoundException("Order doesn't exist");
            }

            return order;
        }

        public static Order GetOrderNotExists(this IOrderRepository _orderRepository, Guid id)
        {
            var order = _orderRepository.GetOrder(id);
            if (order != null)
            {
                throw new Exception("Order allready exist");
            }

            return order;
        }

        public static Order GetOrderExists(this IOrderRepository _orderRepository, Guid id)
        {
            var order = _orderRepository.GetOrder(id);
            if (order == null)
            {
                throw new NotFoundException("Order doesn't exist");
            }

            return order;
        }
    }


}
