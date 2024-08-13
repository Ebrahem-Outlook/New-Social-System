using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Posts.Commands.CreatePost;

public sealed record CreatePostCommand(
    Guid UserId, 
    string Title, 
    string Context) : ICommand<string>;
