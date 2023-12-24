using CQRS_MediatR.Commands;
using CQRS_MediatR.Notifications;
using CQRS_MediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_MediatR.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await this._mediator.Send(new GetProductsQuery());
            return Ok(products);    
        }

        [HttpGet("{id:int}", Name = "GetProductById")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await this._mediator.Send(new GetProductByIdQuery(id));
            if (product == null)
                return NotFound("Product not found!");
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] Product product)
        {
            var result = await this._mediator.Send(new AddProductCommand(product));

            //notifications
            await _mediator.Publish(new ProductAddedNotification(result));

            return CreatedAtRoute("GetProductById", new { id = result.Id }, result);
        }
    }
}
