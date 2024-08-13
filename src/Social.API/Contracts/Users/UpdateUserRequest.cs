namespace Social.API.Contracts.Users;

public sealed record UpdateUserRequest(
    Guid UserId, 
    string FirstName,
    string LastName);
