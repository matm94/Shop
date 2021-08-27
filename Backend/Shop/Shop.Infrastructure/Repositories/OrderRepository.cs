using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;
using Shop.Core.Repositories;
using Shop.Db;
using Shop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShopDbContext _shopDbContext;
        public OrderRepository(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public Order GetOrder(string lastName)
            => _shopDbContext.OrderDbSet.SingleOrDefault(x => x.LastName.ToLower() == lastName.ToLower());
        public Order GetOrder(Guid id)
            => _shopDbContext.OrderDbSet.FirstOrDefault(x => x.Id == id);
        public Order GetCompleteOrder(Guid id)
            => _shopDbContext.OrderDbSet
            .Include(x => x.Product)
            .Include(x => x.Product.Collars)
            .Include(x => x.Product.NormalLeashes)
            .Include(x => x.Product.ReversibleLeashes)
            .Include(x => x.Product.Suspenders)
            .Include(x => x.Product.TrainingLeashes)
            .SingleOrDefault(x => x.Id == id);
        public IEnumerable<Order> GetAll(string searchPhrase, int PageNumber, int PageSize)
           => _shopDbContext.OrderDbSet
            .Where(x => searchPhrase == null || x.LastName.ToLower().Contains(searchPhrase.ToLower()));
        public void AddOrder(Order order)
        {
            _shopDbContext.OrderDbSet.Add(order);
            _shopDbContext.SaveChanges();
        }
        public void UpdateOrder(Order order)
        {
            _shopDbContext.OrderDbSet.Update(order);
            _shopDbContext.SaveChanges();
        }
        public void DeleteOrder(Guid id)
        {
            var order = _shopDbContext.OrderDbSet.SingleOrDefault(x => x.Id == id);
            _shopDbContext.OrderDbSet.Remove(order);
            _shopDbContext.SaveChanges();
        }


    }
}
