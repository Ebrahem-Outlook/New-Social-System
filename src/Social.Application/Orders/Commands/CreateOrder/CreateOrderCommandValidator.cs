using FluentValidation;

namespace Social.Application.Orders.Commands.CreateOrder;

internal sealed class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderCommandValidator()
    {
        RuleFor(order => order.OrderItems).NotNull().NotEmpty().WithMessage("OrderItems can't be null or empty");
    }
}