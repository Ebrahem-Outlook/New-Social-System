using FluentValidation;

namespace Social.Application.Posts.Commands.CreatePost;

internal sealed class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
{
    public CreatePostCommandValidator()
    {
        RuleFor(post => post.UserId).NotNull().NotEmpty().WithMessage("UserId can't be null or empty.");

        RuleFor(post => post.Title).NotNull().NotEmpty().WithMessage("Titlecan't be null or empty.");

        RuleFor(post => post.Context).NotNull().NotEmpty().WithMessage("Context can't be null or empty.");
    }
}
