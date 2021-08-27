using AutoMapper;
using Shop.Core.Domain;
using Shop.Core.Repositories;
using Shop.Infrastructure.Extensions;
using Shop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Shop.Infrastructure.Querys;

namespace Shop.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<OrderService> _logger; 

        public OrderService(IOrderRepository orderRepository, IMapper mapper, ILogger<OrderService> logger)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _logger = logger;
        }
        public OrderDTO Get(string lastName)
        {
            _logger.LogError($"Order with lastName: {lastName} Get action invoked");
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
        public PageResult<OrderDTO> GetAll(OrderQuery query)
        {
            var baseQuery = _orderRepository.GetAll(query.SearchPhrase,query.PageNumber,query.PageSize).ToList();
            var orders = baseQuery
                         .Skip(query.PageSize * (query.PageNumber - 1))
                         .Take(query.PageSize)
                         .ToList();
            var totalItemsCount = baseQuery.Count();

            var orderDtos = _mapper.Map<List<OrderDTO>>(orders);
            return new PageResult<OrderDTO>(orderDtos, query.PageSize, query.PageNumber, totalItemsCount); 
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
            _logger.LogError($"Order with id: {id} DELETE action invoked");
            var order =_orderRepository.GetOrderExists(id);
            _orderRepository.DeleteOrder(order.Id);
        }
    }
}
