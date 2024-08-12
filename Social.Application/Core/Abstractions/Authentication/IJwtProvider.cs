using Social.Domain.Users;

namespace Social.Application.Core.Abstractions.Authentication;

public interface IJwtProvider
{
    string GenerateToken(User user);
}
