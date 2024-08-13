using FluentValidation;

namespace Social.Application.Orders.Queries.GetByOrderId;

internal sealed class GetByOrderIdQueryValidator : AbstractValidator<GetByOrderIdQuery>
{
    public GetByOrderIdQueryValidator()
    {
        RuleFor(order => order.OrderId).NotEmpty().NotEmpty().WithMessage("OrderId can't be null or empty.");
    }
}
