using FluentValidation;

namespace Social.Application.Posts.Commands.UpdatePost;

internal sealed class UpdatePostCommandValidator : AbstractValidator<UpdatePostCommand>
{
    public UpdatePostCommandValidator()
    {
        RuleFor(post => post.UserId).NotNull().NotEmpty().WithMessage("UserId can't be null or empty.");

        RuleFor(post => post.PostId).NotNull().NotEmpty().WithMessage("PostId Scan't be null or empty.");

        RuleFor(post => post.Title).NotNull().NotEmpty().WithMessage("Title can't be null or empty.");

        RuleFor(post => post.Context).NotNull().NotEmpty().WithMessage("Context can't be null or empty.");
    }
}
