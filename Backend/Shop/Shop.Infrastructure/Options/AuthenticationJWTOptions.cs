using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Options
{
    public class AuthenticationJWTOptions
    {
        public string JWTKey { get; set; }
        public int JWTExpireTime { get; set; }
        public string JWTIssuer { get; set; }
    }
}
