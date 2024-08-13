using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Posts.Commands.UpdatePost;

internal sealed class UpdatePostCommandHandler : ICommandHandler<UpdatePostCommand, string>
{
    public Task<string> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
