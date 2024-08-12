namespace Social.Domain.Users;

public interface IUserRepository
{
    // Commands.
    Task AddAsync(User user, CancellationToken cancellationToken);
    Task Update(User user, CancellationToken cancellationToken);
    Task Delete(User user, CancellationToken cancellationToken);

    // Queries.
    Task<List<User>> GetAllAsync(CancellationToken cancellationToken);
    Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<User> GetByEmailAsync(string email, CancellationToken cancellationToken);
    Task<bool> IsEmailUnique(string email, CancellationToken cancellationToken);
    Task<bool> IsUserNameUnique(string userName, CancellationToken cancellationToken);
}
