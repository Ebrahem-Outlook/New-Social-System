using FluentValidation;

namespace Social.Application.Posts.Queries.GetById;

internal sealed class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
{
    public GetByIdQueryValidator()
    {
        RuleFor(post => post.PostId).NotNull().NotEmpty().WithMessage("PostId can't be null or empty.");
    }
}
