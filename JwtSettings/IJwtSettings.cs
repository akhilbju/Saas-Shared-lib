public interface IJwtSettings
{
    string GenerateToken(string userId, string role);
}