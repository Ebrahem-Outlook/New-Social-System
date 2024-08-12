using MediatR;

namespace Social.Application.Core.Abstractions.Messaging;

/// <summary>
/// 
/// </summary>
/// <typeparam name="TQuery"></typeparam>
public interface IQueryHandler<in TQuery> : IRequestHandler<TQuery>
    where TQuery : IQuery
{

}

/// <summary>
/// 
/// </summary>
/// <typeparam name="TQuery"></typeparam>
/// <typeparam name="TResponse"></typeparam>
public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
    where TResponse : class
{

}
