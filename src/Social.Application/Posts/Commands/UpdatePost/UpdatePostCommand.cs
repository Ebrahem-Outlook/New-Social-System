using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Posts.Commands.UpdatePost;

public sealed record UpdatePostCommand(
    Guid UserId, 
    Guid PostId,
    string Title,
    string Context) : ICommand<string>;
