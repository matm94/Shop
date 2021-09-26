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
    [Route("api/order/{orderId}/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("Collar")]
        [HttpPost]
        public ActionResult Post([FromBody] CollarDTO dto, Guid orderId)
        {
            _productService.AddCollar(orderId, dto);
            return Created($"api/order/{orderId}/[controller]/Collar/" + dto.Id, null);
        }

        [Route("NormalLeash")]
        [HttpPost]
        public ActionResult Post([FromBody] NormalLeashDTO dto, Guid orderId)
        {
            _productService.AddNormalLeash(orderId, dto);
            return Created($"api/order/{orderId}/[controller]/NormalLeash/" + dto.Id, null);
        }

        [Route("ReversibleLeash")]
        [HttpPost]
        public ActionResult Post([FromBody] ReversibleLeashDTO dto, Guid orderId)
        {
            _productService.AddReversibleLeash(orderId, dto);
            return Created($"api/order/{orderId}/[controller]/ReversibleLeash/" + dto.Id, null);
        }

        [Route("Suspenders")]
        [HttpPost]
        public ActionResult Post([FromBody] SuspendersDTO dto, Guid orderId)
        {
            _productService.AddSuspenders(orderId, dto);
            return Created($"api/order/{orderId}/[controller]/Suspenders/" + dto.Id, null);
        }
        [Route("TrainingLeash")]
        [HttpPost]
        public ActionResult Post([FromBody] TrainingLeashDTO dto, Guid orderId)
        {
            _productService.AddTrainingLeash(orderId, dto);
            return Created($"api/order/{orderId}/[controller]/TrainingLeash/" + dto.Id, null);
        }
    }
}
