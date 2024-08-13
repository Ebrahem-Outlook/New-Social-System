using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Products;

namespace Social.Application.Products.Queries.GetById;

public sealed record GetByIdQuery(Guid ProductId) : IQuery<Product>;
