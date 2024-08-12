using FluentValidation;

namespace Social.Application.Users.Commands.CreateUser;

internal sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(user => user.FirstName).NotNull().NotEmpty().WithMessage("FirstName of user can't be null or empty...");

        RuleFor(user => user.LastName).NotNull().NotEmpty().WithMessage("LastName of user can't be null or empty...");

        RuleFor(user => user.UserName).NotNull().NotEmpty().WithMessage("UserName  of user can't be null or empty...");

        RuleFor(user => user.Email).NotNull().NotEmpty().WithMessage("Email of user can't be null or empty...");

        RuleFor(user => user.Password).NotNull().NotEmpty().WithMessage("Password of user can't be null or empty...");
    }
}
