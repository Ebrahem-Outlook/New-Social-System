namespace Social.Domain.Messages;

public interface IMessageRepository
{
    // Commands.
    Task AddAsync(Message message); 
    Task UpdateAsync(Message message); 
    Task DeleteAsync(Guid id); 

    // Queries.
    Task<Message?> GetByIdAsync(Guid id); 
    Task<IEnumerable<Message>> GetMessagesByUserIdAsync(Guid userId); 
}
