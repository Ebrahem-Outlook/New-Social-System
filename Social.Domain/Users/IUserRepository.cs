namespace Social.Domain.Users;

public interface IUserRepository
{
    // Commands.
    Task AddAsync(User user, CancellationToken cancellationToken);
    Task Update(User user, CancellationToken cancellationToken);
    Task Delete(User user, CancellationToken cancellationToken);

    // Queries.
    Task GetAllAsync(CancellationToken cancellationToken);
    Task GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task GetByEmailAsync(string email, CancellationToken cancellationToken);
}
