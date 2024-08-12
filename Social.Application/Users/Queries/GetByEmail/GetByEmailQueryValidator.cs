using FluentValidation;

namespace Social.Application.Users.Queries.GetByEmail;

internal sealed class GetByEmailQueryValidator : AbstractValidator<GetByEmailQuery>
{
    public GetByEmailQueryValidator()
    {
        RuleFor(user => user.Email).NotNull().NotEmpty().WithMessage("Email can't be null or empty...");
    }
}
