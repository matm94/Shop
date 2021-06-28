using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Infrastructure.Models;
using Shop.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [Route("GetOrderByLastName/{lastName}")]
        public ActionResult<OrderDTO> Get(string lastName)
        {
            var order = _orderService.Get(lastName);
            return Ok(order);
        }
        [HttpGet]
        [Route("GetOrderById/{id}")]
        public ActionResult<OrderDTO> Get(Guid id)
        {
            var order = _orderService.Get(id);
            return Ok(order);
        }

        [HttpGet]
        [Route("GetCompleteOrderById/{id}")]
        public ActionResult<OrderDTO> GetCompleteOrder(Guid id)
        {
            var order = _orderService.GetCompleteOrder(id);
            return Ok(order);
        }

        [HttpGet]
        [Route("/GetAllOrders")]
        public ActionResult<IEnumerable<OrderDTO>> GetAll()
        {
            var order = _orderService.GetAll();
            return Ok(order);
        }

        [HttpPost]
        public ActionResult Post([FromBody] OrderDTO orderDTO)
        {
           _orderService.Create(orderDTO.FirstName, orderDTO.LastName, orderDTO.PhoneNumber,
               orderDTO.Email, orderDTO.OrderStatus,orderDTO.ShipmentStatus);
            return Created("api/[controller]/" + orderDTO.LastName , null);
        }

        [HttpDelete]
        [Route("DeleteUserById/{id}")]
        public ActionResult Delete(Guid id)
        {
            _orderService.Delete(id);
            return Ok();
        }
    }
}
