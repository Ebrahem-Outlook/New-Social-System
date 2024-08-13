using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Orders;

namespace Social.Application.Orders.Queries.GetByUserId;

internal sealed class GetByUserIdQueryHandler : IQueryHandler<GetByUserIdQuery, List<Order>>
{
    public Task<List<Order>> Handle(GetByUserIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
