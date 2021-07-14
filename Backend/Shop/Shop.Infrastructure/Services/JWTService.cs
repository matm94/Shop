using Microsoft.IdentityModel.Tokens;
using Shop.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Services
{
    public class JWTService : IJWTService
    {
        private readonly JWTSettings _jWTSettings;

        public JWTService(JWTSettings jWTSettings)
        {
            _jWTSettings = jWTSettings;
        }

        public string GenerateTokenJWT(Guid id, string login, string email, string role)
        {
           var claims = new List<Claim>()
           {
               new Claim(ClaimTypes.NameIdentifier, id.ToString()),
               new Claim(ClaimTypes.Name, login),
               new Claim(ClaimTypes.Email, email),
               new Claim(ClaimTypes.Role, role),
           };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jWTSettings.JWTKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var exp = DateTime.Now.AddDays(_jWTSettings.JWTExpireTime);

            var token = new JwtSecurityToken(
                _jWTSettings.JWTIssuer,
                _jWTSettings.JWTIssuer,
                claims,
                expires: exp,
                signingCredentials: cred
                );
            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);



        }
    }
}
