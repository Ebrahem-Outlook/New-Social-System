using Social.Application.Core.Abstractions.Messaging;

namespace Social.Application.Users.Commands.CreateUser;

public sealed record CreateUserCommand(
    string FirstName, 
    string LastName, 
    string UserName, 
    string Email, 
    string Password) : ICommand<string>;
