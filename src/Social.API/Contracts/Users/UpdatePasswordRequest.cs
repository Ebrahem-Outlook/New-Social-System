namespace Social.API.Contracts.Users;

public sealed record UpdatePasswordRequest(Guid UserId, string Password);
