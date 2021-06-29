using Shop.Core.Domain;
using System;

namespace Shop.Infrastructure.Models
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }

    }
}
