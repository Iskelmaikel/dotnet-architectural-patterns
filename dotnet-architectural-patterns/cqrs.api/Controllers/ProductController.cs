using cqrs.api.Models;
using cqrs.api.Resources.Commands.Product;
using cqrs.api.Resources.Queries.Product;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace cqrs.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator) {
            _mediator = mediator;
        }

        public async Task<IActionResult> Get()
        {
            try
            {
                var command = new GetAllProductsQuery();
                var response = await _mediator.Send(command);
                return response != null ? Ok(response) : NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var command = new GetProductByIdQuery() { Id = id };
                var response = await _mediator.Send(command);
                return response != null ? Ok(response) : NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            try
            {
                var command = new CreateProductCommand()
                {
                    Name = product.Name,
                    Description = product.Description,
                    Category = product.Category,
                    Price = product.Price,
                    Active = product.Active,
                };

                var response = await _mediator.Send(command);
                return response != null ? Ok(response) : NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            try
            {
                var command = new UpdateProductCommand()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Category = product.Category,
                    Price = product.Price,
                    Active = product.Active,
                };

                var response = await _mediator.Send(command);
                return response != null ? Ok(response) : NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var command = new DeleteProductCommand() { Id = id };

                var response = await _mediator.Send(command);
                return response != null ? Ok(response) : NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
