using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Services
{
    public interface IJWTService
    {
        string GenerateTokenJWT(Guid id,string login, string email, string role);
    }
}
