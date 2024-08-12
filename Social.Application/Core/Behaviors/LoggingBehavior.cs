using MediatR;
using Microsoft.Extensions.Logging;
using Social.Domain.Core.BaseType.Result;

namespace Social.Application.Core.Behaviors;

internal sealed class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest
    where TResponse : Result
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

    public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger) => _logger = logger;

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Request Started: {@RequestName}, {@RequestDate}", typeof(TRequest).Name, DateTime.UtcNow);

        TResponse response = await next();

        if (response.IsFailure)
        {
            _logger.LogInformation("Request Failure: {@RequestName}, {@RequestDate}, {RequestError}", typeof(TRequest).Name, DateTime.UtcNow, response.Error);
        }

        _logger.LogInformation("Request Started: {@RequestName}, {@RequestDate}", typeof(TRequest).Name, DateTime.UtcNow);

        return response;
    }
}
