using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Products.Commands.DeleteProduct;

public sealed record DeleteProductCommand(Guid UserId, Guid ProductId) : ICommand<string>;
