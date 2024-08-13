using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Orders;

namespace Social.Application.Orders.Queries.GetAll;

internal sealed class GetAllOrdersQueryHandler : IQueryHandler<GetAllOrdersQuery, List<Order>>
{
    public Task<List<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
