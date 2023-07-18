﻿using Amazon.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Application.Services
{
    public interface IOrderItemService
    {
        Task<bool> Create(OrderItemShow cartitem);
        Task<bool> Update(int id, OrderItemShow cartitem);
        Task<bool> Delete(int id);
        Task<List<OrderItemShow>> orderItems();
    }
}
