using Social.Domain.Core.BaseType;
using Social.Domain.Users.Events;

namespace Social.Domain.Users;

public sealed class User : AggregateRoot
{
    public User(string firstName, string lastName, string userName, string email, string passwordHash)
        : base(Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        UserName = userName;
        Email = email;
        PasswordHash = passwordHash;
    }

    private User() : base() { }

    public string FirstName { get; private set; } = default!;
    public string LastName { get; private set; } = default!;
    public string UserName { get; private set; } = default!;
    public string Email { get; private set; } = default!;
    public string PasswordHash { get; private set; } = default!;

    public static User Create(string firstName, string lastName, string userName, string email, string passwordHash)
    {
        User user = new User(firstName, lastName, userName, email, passwordHash);

        user.RaiseDomainEvent(new UserCreatedDomainEvent(user));

        return user;
    }

    public void UpdateUser(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        RaiseDomainEvent(new UserUpdatedDomainEvent(this));
    }

    public void UpdateEmail(string email)
    {
        Email = email;

        RaiseDomainEvent(new UserEmailUpdatedDomainEvent(this));
    }

    public void UpdatePassword(string passwordHash)
    {
        PasswordHash = passwordHash;

        RaiseDomainEvent(new UserPasswordUpdatedDomainEvent(this));
    }
}
