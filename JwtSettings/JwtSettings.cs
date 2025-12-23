using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
public class JwtSettings : IJwtSettings
{
    private readonly JwtConfigurationModel _config;
    public JwtSettings(IOptions<JwtConfigurationModel> config)
    {
        _config = config.Value;
    }
    public string GenerateToken(string userId, string role)
    {
        var claims = new[]
        {
        new Claim(JwtRegisteredClaimNames.Sub, userId),
        new Claim(ClaimTypes.Role, role)
    };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_config.Key!)
        );

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _config.Issuer,
            audience: _config.Audience,
            claims: claims,
            expires: DateTime.UtcNow.AddHours(1),
            signingCredentials: creds);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

}