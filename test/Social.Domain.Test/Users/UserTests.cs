using Social.Domain.Users;

namespace Social.Domain.Test.Users;

public class UserTests
{
    [Fact]
    public void CreateUser_ShouldInitializePropertiesCorrectly_AndRaiseUserCreatedEvent()
    {
        // Arrange
        var firstName = "Ebrahem";
        var lastName = "Mohamed";
        var userName = "Ebrahem_Outlook";
        var email = "Ebrahem@gmail.com";
        var passwordHash = "HashedPassword";

        // Act
        var user = User.Create(firstName, lastName, userName, email, passwordHash);

        // Assert
        Assert.Equal(firstName, user.FirstName);
        Assert.Equal(lastName, user.LastName);
        Assert.Equal(userName, user.UserName);
        Assert.Equal(email, user.Email);
        Assert.Equal(passwordHash, user.PasswordHash);
    }

    [Fact]
    public void UpdateUser_ShouldUpdateFirstNameAndLastName_AndRaiseUserUpdatedEvent()
    {
        // Arrange
        var user = User.Create("Ebrahem", "Mohamed", "Ebrahem_Outlook", "Ebrahem@gmail.com", "HashedPassword");
        var newFirstName = "Omar";
        var newLastName = "Ahemad";

        // Act
        user.UpdateUser(newFirstName, newLastName);

        // Assert
        Assert.Equal(newFirstName, user.FirstName);
        Assert.Equal(newLastName, user.LastName);
    }
}
