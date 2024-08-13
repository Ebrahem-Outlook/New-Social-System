using FluentValidation;

namespace Social.Application.Posts.Queries.GetByName;

internal sealed class GetByNameQueryValidator : AbstractValidator<GetByNameQuery>
{
    public GetByNameQueryValidator()
    {
        RuleFor(post => post.Name).NotNull().NotEmpty().WithMessage("Post Name can't be null or empty.");
    }
}
