using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Products;

namespace Social.Application.Products.Queries.GetById;

internal sealed class GetByIdQueryHandler : IQueryHandler<GetByIdQuery, Product>
{
    public Task<Product> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
