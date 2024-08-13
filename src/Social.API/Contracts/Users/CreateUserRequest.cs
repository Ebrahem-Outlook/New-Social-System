namespace Social.API.Contracts.Users;

public sealed record CreateUserRequest(
    string FirstName, 
    string LastName,
    string UserName, 
    string Email, 
    string Password);
