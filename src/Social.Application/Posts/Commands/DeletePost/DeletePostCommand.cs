using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Posts.Commands.DeletePost;

public sealed record DeletePostCommand(Guid UserId, Guid PostId) : ICommand<string>;

