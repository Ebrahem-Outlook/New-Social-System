using FluentValidation;

namespace Social.Application.Posts.Commands.DeletePost;

internal sealed class DeletePostCommandValidator : AbstractValidator<DeletePostCommand>
{
    public DeletePostCommandValidator()
    {
        RuleFor(post => post.UserId).NotNull().NotEmpty().WithMessage("UserId can't be null or empty.");

        RuleFor(post => post.PostId).NotNull().NotEmpty().WithMessage("PostId can't be null or empty.");
    }
}

