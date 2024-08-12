namespace Social.Application.Core.Abstractions.Notifications;

public interface IEmailNotificationService
{
    Task SendWelcomeEmail(string email);    
}
