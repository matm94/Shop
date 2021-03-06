using Shop.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface IUserRepository
    {
        User GetUser(string email);
        User GetUser(Guid id);
        IEnumerable<User> GetAll(string searchPhrase);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(Guid id);
        
    }
}
