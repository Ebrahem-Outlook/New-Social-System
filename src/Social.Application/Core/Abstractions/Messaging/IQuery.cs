using MediatR;

namespace Social.Application.Core.Abstractions.Messaging;

/// <summary>
/// 
/// </summary>
public interface IQuery : IRequest
{

}

/// <summary>
/// 
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : class
{

}
