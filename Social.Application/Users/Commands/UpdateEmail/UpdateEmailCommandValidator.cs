using FluentValidation;

namespace Social.Application.Users.Commands.UpdateEmail;

internal sealed class UpdateEmailCommandValidator : AbstractValidator<UpdateEmailCommand>
{
    public UpdateEmailCommandValidator()
    {
        RuleFor(user => user.UserId).NotNull().NotEmpty().WithMessage("UserId of user can't be null or empty...");

        RuleFor(user => user.Email).NotNull().NotEmpty().WithMessage("Email of user can't be null or empty...");
    }
}
