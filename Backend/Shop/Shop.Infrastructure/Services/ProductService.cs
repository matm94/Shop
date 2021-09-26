using AutoMapper;
using Microsoft.Extensions.Logging;
using Shop.Core.Domain;
using Shop.Core.Repositories;
using Shop.Infrastructure.Extensions;
using Shop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ILogger<OrderService> _logger;
        public ProductService(IOrderRepository orderRepository, ILogger<OrderService> logger)
        {
            _orderRepository = orderRepository;
            _logger = logger;
        }
        public void AddCollar(Guid orderId, CollarDTO dto)
        {
            var order = _orderRepository.GetCompleteOrder(orderId);
            var newCollar = new Collar(dto.Color, dto.Width, dto.Type, dto.Comments,
                                dto.Price, dto.FixturesColor, dto.NeckCircuit, dto.ClaspType, dto.PetIdRing);
            order.Product.Collars.Add(newCollar);
            _orderRepository.UpdateOrder(order);
        }

        public void AddNormalLeash(Guid orderId, NormalLeashDTO dto)
        {
            var order = _orderRepository.GetCompleteOrder(orderId);
            var newLeash = new NormalLeash(dto.Color, dto.Width, dto.Type, dto.Comments, dto.Lenght, dto.Price, dto.FixturesColor);
            order.Product.NormalLeashes.Add(newLeash);
            _orderRepository.UpdateOrder(order);
        }

        public void AddReversibleLeash(Guid orderId, ReversibleLeashDTO dto)
        {
            var order = _orderRepository.GetCompleteOrder(orderId);
            var newLeash = new ReversibleLeash(dto.Color, dto.Width, dto.Type, dto.Comments, dto.Lenght, dto.Price, 
                dto.FixturesColor, dto.StandardCirclePosition, dto.CirclePositionLength);
            order.Product.ReversibleLeashes.Add(newLeash);
            _orderRepository.UpdateOrder(order);
        }

        public void AddSuspenders(Guid orderId, SuspendersDTO dto)
        {
            var order = _orderRepository.GetCompleteOrder(orderId);
            var newSuspenders = new Suspenders(dto.Color, dto.Width, dto.Type, dto.Comments, dto.Price, dto.FixturesColor,
                dto.ShoulderCircuit, dto.ChestCircuit, dto.ChestShoulderDistanceUp, dto.ChestShoulderDistanceDown, dto.ClaspType);
            order.Product.Suspenders.Add(newSuspenders);
            _orderRepository.UpdateOrder(order);
        }

        public void AddTrainingLeash(Guid orderId, TrainingLeashDTO dto)
        {
            var order = _orderRepository.GetCompleteOrder(orderId);
            var newLeash = new TrainingLeash(dto.Color, dto.Comments, dto.Lenght, dto.Price, dto.Handle);
            order.Product.TrainingLeashes.Add(newLeash);
            _orderRepository.UpdateOrder(order);
        }
    }
}
