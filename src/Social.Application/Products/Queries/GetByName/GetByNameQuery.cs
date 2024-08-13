using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Products;

namespace Social.Application.Products.Queries.GetByName;

public sealed record GetByNameQuery(string Name) : IQuery<List<Product>>;
