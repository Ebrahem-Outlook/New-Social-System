namespace Social.Application.Core.Abstractions.Emails;

public interface IEmailService
{
    Task SendEmailAsync(CancellationToken cancellationToken);
}
