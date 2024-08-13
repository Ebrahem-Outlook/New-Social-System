using Social.Application.Core.Abstractions.Messaging;
using Social.Domain.Products;

namespace Social.Application.Products.Queries.GetAll;

public sealed record GetAllProductsQuery() : IQuery<List<Product>>;

