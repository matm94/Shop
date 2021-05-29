using Shop.Core.Domain;
using Shop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Extensions
{
    public static class UserRepositoryExtension
    {
        public static User GetUserNotExists(this IUserRepository _userRepository, string email)
        {
            var user = _userRepository.GetUser(email);
            if (user != null)
            {
                throw new Exception($"User with this email: {email} exist");
            }
            return user;
        }
        public static User GetUserAllreadyExists(this IUserRepository _userRepository, string email)
        {
            var user = _userRepository.GetUser(email);
            if(user == null)
            {
                throw new Exception($"User with this email: {email} doesn't exist");
            }
            return user;
        }
        public static User GetUserNotExists(this IUserRepository _userRepository, Guid id)
        {
            var user = _userRepository.GetUser(id);
            if (user != null)
            {
                throw new Exception($"User with this id: {id} exist");
            }
            return user;
        }
        public static User GetUserAllreadyExists(this IUserRepository _userRepository, Guid id)
        {
            var user = _userRepository.GetUser(id);
            if (user == null)
            {
                throw new Exception($"User with this id: {id} doesn't exist");
            }
            return user;
        }
    }
}
