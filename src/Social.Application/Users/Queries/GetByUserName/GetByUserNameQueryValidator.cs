using FluentValidation;

namespace Social.Application.Users.Queries.GetByUserName;

internal sealed class GetByUserNameQueryValidator : AbstractValidator<GetByUserNameQuery>
{
    public GetByUserNameQueryValidator()
    {
        RuleFor(user => user.UserName).NotNull().NotEmpty().WithMessage("UserName can't be null or empty.");
    }
}
