using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Messages.Commands.DeleteMessage;

internal sealed class DeleteMessageCommandHandler : ICommandHandler<DeleteMessageCommand, string>
{
    public Task<string> Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
