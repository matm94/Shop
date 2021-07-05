using Microsoft.IdentityModel.Tokens;
using Shop.Core.Domain;
using Shop.Infrastructure.Models;
using Shop.Infrastructure.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Services
{
    public class JwtService : IJwtService
    {
        private readonly AuthenticationJWTOptions _authenticationJWTOptions;
        public JwtService(AuthenticationJWTOptions authenticationJWTOptions)
        {
            _authenticationJWTOptions = authenticationJWTOptions;
        }

        public string CreateToken(Guid id, string email, string role )
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, id.ToString()),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationJWTOptions.JWTKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expi = DateTime.Now.AddDays(_authenticationJWTOptions.JWTExpireTime);
            var token = new JwtSecurityToken
                (
                    _authenticationJWTOptions.JWTIssuer,
                    _authenticationJWTOptions.JWTIssuer,
                    claims,
                    expires: expi,
                    signingCredentials: cred
                );
            var tokenHnadler = new JwtSecurityTokenHandler();
            return tokenHnadler.WriteToken(token);
        }

    }
}
