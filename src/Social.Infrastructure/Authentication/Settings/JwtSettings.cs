namespace Social.Infrastructure.Authentication.Settings;

public class JwtSettings
{
    public const string JwtSetting = "Jwt";

    public JwtSettings()
    {
        Issure = string.Empty;
        Audince = string.Empty;
        SecurityKey = string.Empty;
    }

    public string Issure { get; set; }
    public string Audince { get; set; }
    public string SecurityKey { get; set; }
    public int ExperationTime { get; set; }
}
