using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Social.Application.Core.Abstractions.Authentication;
using Social.Domain.Users;
using Social.Infrastructure.Authentication.Settings;
using System.Text;

namespace Social.Infrastructure.Authentication;

internal sealed class JwtProvider : IJwtProvider
{
    private readonly JwtSettings _jwtSettings;

    public JwtProvider(IOptions<JwtSettings> jwtOptions)
    {
        _jwtSettings = jwtOptions.Value;
    }

    public string GenerateToken(User user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecurityKey));

        return string.Empty;

    }
}
