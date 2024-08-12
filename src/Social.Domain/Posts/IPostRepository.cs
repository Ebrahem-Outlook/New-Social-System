namespace Social.Domain.Posts;

public interface IPostRepository 
{
    // Commands.
    Task AddAsync(Post post, CancellationToken cancellationToken);
    Task Delete(Post post, CancellationToken cancellationToken);
    Task Update(Post post, CancellationToken cancellationToken);

    // Queries.
    Task GetAllPostsAsync(CancellationToken cancellationToken);
    Task GetAllLikesAsync(CancellationToken cancellationToken);
    Task GetAllCommentsAsync(CancellationToken cancellationToken);
    Task GetPostByIdAsync(Guid id, CancellationToken cancellationToken);
    Task GetPostByNameAsync(string name, CancellationToken cancellationToken);
}
