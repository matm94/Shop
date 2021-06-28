using AutoMapper;
using Shop.Core.Domain;
using Shop.Core.Repositories;
using Shop.Db;
using Shop.Infrastructure.Extensions;
using Shop.Infrastructure.Models;
using Shop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public OrderDTO Get(string lastName)
        {
            var order =_orderRepository.GetOrderExists(lastName);
            return _mapper.Map<OrderDTO>(order);
        }
        public OrderDTO Get(Guid id)
        {
            var order = _orderRepository.GetOrderExists(id);
            return _mapper.Map<OrderDTO>(order);
        }
        public CompleteOrderDTO GetCompleteOrder(Guid id)
        {
            var order = _orderRepository.GetOrderExists(id);
            _orderRepository.GetCompleteOrder(order.Id);
            return _mapper.Map<CompleteOrderDTO>(order);
        }
        public IEnumerable<OrderDTO> GetAll()
        {
            var orders = _orderRepository.GetAll().ToList();
            return _mapper.Map<IEnumerable<OrderDTO>>(orders);
        }
        public void Create(string firstName, string lastName, string phoneNumber,
            string email, string orderStatus, string shipmentStatus)
        {
            _orderRepository.GetOrderNotExists(lastName);
            var order = new Order(firstName, lastName, phoneNumber, email, orderStatus, shipmentStatus);
            _orderRepository.AddOrder(order);
        }
        public void Delete(Guid id)
        {
            var order =_orderRepository.GetOrderExists(id);
            _orderRepository.DeleteOrder(order.Id);
        }
    }
}
