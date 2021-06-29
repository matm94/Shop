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
        [Key]
        [Required]
        public Guid Id { get; protected set; }

        [Required]
        [MinLength(3, ErrorMessage = "Login must contains min. 6 characters")]
        [MaxLength(20, ErrorMessage = "Login can contains only 20 characters")]
        public string Login { get; protected set; }

        [Required]
        [MinLength(6, ErrorMessage = "Password must contains min. 6 characters")]
        public string Password { get; set; }

        [Required]
        public string Email { get; protected set; }
        public bool IsActive { get; protected set; }
        public string Role { get; set; }

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
