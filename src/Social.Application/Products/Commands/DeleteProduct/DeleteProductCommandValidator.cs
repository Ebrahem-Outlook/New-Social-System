using FluentValidation;

namespace Social.Application.Products.Commands.DeleteProduct;

internal sealed class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
{
    public DeleteProductCommandValidator()
    {
        RuleFor(user => user.UserId).NotNull().NotEmpty().WithMessage("UserId can't be null or empty.");

        RuleFor(user => user.ProductId).NotNull().NotEmpty().WithMessage("ProductId can't be null or empty.");
    }
}
