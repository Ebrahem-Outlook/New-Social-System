using FluentValidation;

namespace Social.Application.Users.Commands.UpdateUser;

internal sealed class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(user => user.UserId).NotNull().NotEmpty().WithMessage("UserId can't be null or empty...");

        RuleFor(user => user.FirstName).NotNull().NotEmpty().WithMessage("FirstName can't be null or empty...");

        RuleFor(user => user.LastName).NotNull().NotEmpty().WithMessage("LastName can't be null or empty...");
    }
}
