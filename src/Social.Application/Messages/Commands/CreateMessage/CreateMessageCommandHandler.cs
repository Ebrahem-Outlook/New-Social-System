using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Messages.Commands.CreateMessage;

internal sealed class CreateMessageCommandHandler : ICommandHandler<CreateMessageCommand, string>
{
    public Task<string> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
