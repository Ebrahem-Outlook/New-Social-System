namespace Social.Domain.Orders;

public interface IOrderRepository
{
    // Commands.
    Task AddAsync(Order order, CancellationToken cancellationToken);

    // Queries.
    Task<List<Order>> GetAllAsync(CancellationToken cancellationToken);
    Task<List<Order>> GetByUserIdAsync(Guid userId, CancellationToken cancellationToken);
    Task<Order?> GetByOrderIdAsync(Guid orderId, CancellationToken cancellationToken);
}
