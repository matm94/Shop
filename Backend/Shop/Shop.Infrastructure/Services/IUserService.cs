using Shop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Services
{
    public interface IUserService
    {
        UserDTO Get(string email);
        UserDTO Get(Guid id);
        IEnumerable<UserDTO> GetAll(string searchPhrase);
        void RegisterUser(RegisterUserDTO registerUserDTO);
        string LoginUser(LoginUserDTO loginUserDTO);
        void Create(string login, string password, string email, string role);
        void Update(string login, string password, string email);
        void DeleteUser(Guid id);
    }
}
