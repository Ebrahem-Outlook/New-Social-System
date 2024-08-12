using FluentValidation;

namespace Social.Application.Users.Commands.DeleteUser;

internal sealed class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
{
    public DeleteUserCommandValidator()
    {
        RuleFor(user => user.UserId).NotNull().NotEmpty().WithMessage("UserId can't be null or empty...");
    }
}
