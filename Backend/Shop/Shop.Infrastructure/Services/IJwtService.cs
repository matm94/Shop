using Shop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Services
{
    public interface IJwtService
    {
        string CreateToken(Guid id, string email, string role);
    }
}
