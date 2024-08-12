using MediatR;

namespace Social.Application.Core.Abstractions.Messaging;

/// <summary>
/// 
/// </summary>
public interface ICommand : IRequest
{

}

/// <summary>
/// 
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface ICommand<out TResponse> : IRequest<TResponse>
    where TResponse : class
{

}
