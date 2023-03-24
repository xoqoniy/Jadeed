namespace Jadeed.Service.Commons.Security;

public class PasswordHasher
{
    public static (string Hash, string Salt) GetHash(string password)
    {
        string salt = Guid.NewGuid().ToString();
        string hash = BCrypt.Net.BCrypt.HashPassword(salt + password);
        return (Hash: hash, Salt: salt);

    }

    public static bool Verify(string pasword, string salt, string hash)
    {
        return BCrypt.Net.BCrypt.Verify(salt + pasword, hash);
    }

    public static string ChangePassword(string password, string salt)
    {
        return BCrypt.Net.BCrypt.HashPassword(salt + password);
    }

}
