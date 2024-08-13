using FluentValidation;

namespace Social.Application.Products.Commands.UpdateProduct;

internal sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(product => product.UserId).NotNull().NotEmpty().WithMessage("UserId can't be null or empty.");

        RuleFor(product => product.ProductId).NotNull().NotEmpty().WithMessage("ProductId can't be null or empty.");

        RuleFor(product => product.Name).NotNull().NotEmpty().WithMessage("Name can't be null or empty.");

        RuleFor(product => product.Description).NotNull().NotEmpty().WithMessage("Description can't be nullame  or empty.");

        RuleFor(product => product.Price).NotNull().NotEmpty().WithMessage("Price can't be null or empty.");

        RuleFor(product => product.Stock).NotNull().NotEmpty().WithMessage("Stock can't be null or empty.");
    }
}
