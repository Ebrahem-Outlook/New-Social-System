namespace Social.Application.Core.Abstractions.Cryptography;

/// <summary>
/// 
/// </summary>
public interface IPasswordHasher
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="password"></param>
    /// <returns></returns>
    Task<string> HashPassword(string password);
}
