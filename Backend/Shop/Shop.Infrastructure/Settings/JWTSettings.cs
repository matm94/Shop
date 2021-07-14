using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Settings
{
    public class JWTSettings
    {
        public string JWTKey { get; set; }
        public int JWTExpireTime { get; set; }
        public string JWTIssuer { get; set; }
    }
}
