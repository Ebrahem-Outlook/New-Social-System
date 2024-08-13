using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Products;

namespace Social.Application.Products.Queries.GetByName;

internal sealed class GetByNameQueryHandle : IQueryHandler<GetByNameQuery, List<Product>>
{
    private readonly IProductRepository _productRepository;

    public GetByNameQueryHandle(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task<List<Product>> Handle(GetByNameQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
