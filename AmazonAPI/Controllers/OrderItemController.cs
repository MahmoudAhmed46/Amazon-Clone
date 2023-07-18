using Amazon.Application.Contracts;
using Amazon.Application.Services;
using Amazon.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmazonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemService orderService;

        public OrderItemController(IOrderItemService orderService)
        {
            this.orderService = orderService;
        }
        [HttpGet]
        [Route("AllItems")]
        public async Task<IActionResult> AllItems()
        {
            List<OrderItemShow> orderItems = await orderService.orderItems();
            return Ok(orderItems);
        }
        [HttpPost]
        public async Task<IActionResult> Create(OrderItemShow orderItemShow)
        {
            var res = await orderService.Create(orderItemShow);
            return Ok(res);
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id,OrderItemShow orderItemShow)
        {
            var res = await orderService.Update(id, orderItemShow);
            return Ok(res);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var res = await orderService.Delete(id);
            return Ok(res);
        }
    }
}
