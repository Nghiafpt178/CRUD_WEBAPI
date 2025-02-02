﻿using BusinessObject;
using DataAccess.DTOs;
using eStoreAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        void SaveOrder(OrderRespond ord);

        Order GetOrderByID(int id);

        void UpdateOrder(int id, OrderRespond ord);

        List<Order> GetOrders();
    }
}
