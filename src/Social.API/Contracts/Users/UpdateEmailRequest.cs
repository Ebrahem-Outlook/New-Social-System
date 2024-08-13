namespace Social.API.Contracts.Users;

public sealed record UpdateEmailRequest(Guid UserId, string Email);
