using FluentValidation;

namespace Social.Application.Messages.Commands.CreateMessage;

internal sealed class CreateMessageCommandValidator : AbstractValidator<CreateMessageCommand>
{
    public CreateMessageCommandValidator()
    {
        RuleFor(message => message.UserSendId).NotEmpty().NotEmpty().WithMessage("UserSendId can't be null or empty.");

        RuleFor(message => message.UserReceiveId).NotEmpty().NotEmpty().WithMessage("UserReceiveId can't be null or empty.");

        RuleFor(message => message.MessageBody).NotEmpty().NotEmpty().WithMessage("Message can't be null or empty.");
    }
}
