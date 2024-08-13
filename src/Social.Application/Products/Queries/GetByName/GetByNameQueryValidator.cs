using FluentValidation;

namespace Social.Application.Products.Queries.GetByName;

internal sealed class GetByNameQueryValidator : AbstractValidator<GetByNameQuery>
{
    public GetByNameQueryValidator()
    {
        RuleFor(product => product.Name).NotNull().NotEmpty().WithMessage("Product Name can't by null or empty.");
    }
}
