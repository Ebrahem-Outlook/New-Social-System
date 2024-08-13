using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Orders;

namespace Social.Application.Orders.Queries.GetByOrderId;

internal sealed class GetByOrderIdQueryHandler : IQueryHandler<GetByOrderIdQuery, Order>
{
    public Task<Order> Handle(GetByOrderIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
