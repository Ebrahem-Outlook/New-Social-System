using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Products.Commands.CreateProduct;

public sealed record CreateProductCommand(
    Guid UserId,
    string Name, 
    string Description, 
    decimal Price,
    int Stock) : ICommand<string>;
