using FluentValidation;

namespace Social.Application.Products.Queries.GetById;

internal sealed class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
{
    public GetByIdQueryValidator()
    {
        RuleFor(product => product.ProductId).NotNull().NotEmpty().WithMessage("ProductId can't be null or empyt.");
    }
}
