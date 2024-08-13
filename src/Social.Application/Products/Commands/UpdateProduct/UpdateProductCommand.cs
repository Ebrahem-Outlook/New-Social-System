using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Products.Commands.UpdateProduct;

public sealed record UpdateProductCommand(
    Guid UserId, 
    Guid ProductId, 
    string Name, 
    string Description, 
    decimal Price, 
    int Stock) : ICommand<string>;
