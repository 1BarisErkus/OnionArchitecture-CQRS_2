using App.Application.Abstractions;
using App.Domain.Entities;
using AutoMapper;
using MediatR;

namespace App.Application.Features.Queries.GetAllProduct
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
    {
        readonly IProductService _productService;
        readonly IMapper _mapper;

        public GetAllProductQueryHandler(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            List<Product> products = _productService.GetProducts();

            List<GetAllProductQueryResponse> response = _mapper.Map<List<GetAllProductQueryResponse>>(products);

            return new GetAllProductQueryResponse()
            {
                Name = "asd",
                Price = response[0].Price
            };
        }
    }
}
