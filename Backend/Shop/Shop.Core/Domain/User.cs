using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Domain
{
    public class User
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Login must contains min. 6 characters")]
        [MaxLength(20, ErrorMessage = "Login can contains only 20 characters")]
        public string Login { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Password must contains min. 6 characters")]
        [MaxLength(20, ErrorMessage = "Password can contains only 20 characters")]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }

        public User(string login, string password, string email, string role)
        {
            Id = Guid.NewGuid();
            Login = login;
            Password = password;
            Email = email;
            Role = role;
        }

        public User(string login, string password, string email)
        {
            Id = Guid.NewGuid();
            Login = login;
            Password = password;
            Email = email;
        }

    }
}
