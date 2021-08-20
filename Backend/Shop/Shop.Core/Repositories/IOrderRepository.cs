﻿using Shop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface IOrderRepository
    {
        Order GetOrder(string lastName);
        Order GetOrder(Guid id);
        Order GetCompleteOrder(Guid id);
        IEnumerable<Order> GetAll(string searchPhrase);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Guid id);
    }
}
