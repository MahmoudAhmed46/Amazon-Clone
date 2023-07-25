using Amazon.Application.Contracts;
using Amazon.Domain;
using Amazon.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderReposatory orderReposatory;
        private readonly IOrderItemReposatory orderItem;
        private readonly IMapper mapper;

        public OrderService(IOrderReposatory orderReposatory,IOrderItemReposatory orderItem
            ,IMapper mapper)
        {
            this.orderReposatory = orderReposatory;
            this.orderItem = orderItem;
            this.mapper = mapper;
        }

        public async Task<OrderDTO> Create(OrderDTO orderDTO)
        {
            var orderModel = mapper.Map<Order>(orderDTO);
            var order= await orderReposatory.CreateAsync(orderModel);
            return mapper.Map<OrderDTO>(order);
            
        }

        public async Task<bool> Delete(int id)
        {
            await orderItem.deleteOrderItemsByOrderId(id);
            var res= await orderReposatory.DeleteAsync(id);
            await orderReposatory.SaveChangesAsync();
            return res;
        }

        public async Task<List<OrderDTO>> getAllByUserId(string id)
        {
            var orders= await orderReposatory.getAllOrdersByUserId(id);
            return mapper.Map<List<OrderDTO>>(orders);
        }

        public async Task<OrderDTO> GetByIdAsync(int id)
        {
            var order = await orderReposatory.GetByIdAsync(id);
            return mapper.Map<OrderDTO>(order);
        }

        public async Task<OrderDTO> Update(OrderDTO orderDTO)
        {
            var order = mapper.Map<Order>(orderDTO);
            var res= await orderReposatory.UpdateAsync(order);
            return mapper.Map<OrderDTO>(res);
        }
    }
}
