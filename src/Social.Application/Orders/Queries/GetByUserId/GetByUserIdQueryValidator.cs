using FluentValidation;

namespace Social.Application.Orders.Queries.GetByUserId;

internal sealed class GetByUserIdQueryValidator : AbstractValidator<GetByUserIdQuery>
{
    public GetByUserIdQueryValidator()
    {
        RuleFor(order => order.UserId).NotEmpty().NotEmpty().WithMessage("UserId can't be null or empty");
    }
}
