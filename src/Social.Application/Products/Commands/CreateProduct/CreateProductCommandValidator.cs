using FluentValidation;

namespace Social.Application.Products.Commands.CreateProduct;

internal sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(product => product.UserId).NotNull().NotEmpty().WithMessage("UserId can't be null or empty");

        RuleFor(product => product.Name).NotNull().NotEmpty().WithMessage("Product Name can't be null or empty");

        RuleFor(product => product.Description).NotNull().NotEmpty().WithMessage("Product Description can't be null or empty");

        RuleFor(product => product.Price).NotNull().NotEmpty().WithMessage("Product Price can't be null or empty");

        RuleFor(product => product.Stock).NotNull().NotEmpty().WithMessage("Product Stock can't be null or empty");
    }
}
