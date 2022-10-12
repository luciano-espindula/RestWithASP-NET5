using System.Collections.Generic;
using System.Security.Claims;

namespace RestWithASPNET.Services
{
    public interface ITokenService
    {
        string GenerateAccesToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
