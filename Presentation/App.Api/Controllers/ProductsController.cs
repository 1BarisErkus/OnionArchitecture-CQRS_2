using App.Application.Abstractions;
using App.Application.Features.Queries.GetAllProduct;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts(GetAllProductQueryRequest getAllProductQueryRequest)
        {
            GetAllProductQueryResponse products = await _mediator.Send(getAllProductQueryRequest);
            return Ok(products);
        }
    }
}
