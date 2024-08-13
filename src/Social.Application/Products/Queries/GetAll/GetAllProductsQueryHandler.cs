using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Products;

namespace Social.Application.Products.Queries.GetAll;

internal sealed class GetAllProductsQueryHandler : IQueryHandler<GetAllProductsQuery, List<Product>>
{
    public Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

