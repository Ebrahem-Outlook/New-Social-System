using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Posts.Commands.DeletePost;

internal sealed class DeletePostCommandHandle : ICommandHandler<DeletePostCommand, string>
{
    public Task<string> Handle(DeletePostCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

