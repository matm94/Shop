using Microsoft.EntityFrameworkCore;
using Shop.Core.Domain;
using Shop.Core.Repositories;
using Shop.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ShopDbContext _shopDbContext;
 
        public UserRepository(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public User GetUser(string email)
            => _shopDbContext.UserDbSet.SingleOrDefault(x => x.Email.ToLower() == email.ToLower());

        public User GetUser(Guid id)
            => _shopDbContext.UserDbSet.SingleOrDefault(x => x.Id == id);

        public IEnumerable<User> GetAll(string searchPhrase)
            => _shopDbContext.UserDbSet
            .Where(x => searchPhrase == null || x.Login.ToLower().Contains(searchPhrase.ToLower()))
            .ToList();

        public void UpdateUser(User user)
        {
            _shopDbContext.UserDbSet.Update(user);
            _shopDbContext.SaveChanges();
        }
        public void AddUser(User user)
        {
            _shopDbContext.UserDbSet.Add(user);
            _shopDbContext.SaveChanges();
        }
        public void DeleteUser(Guid id)
        {
            var user = _shopDbContext.UserDbSet.SingleOrDefault(x => x.Id == id);
            _shopDbContext.UserDbSet.Remove(user);
            _shopDbContext.SaveChanges();
        }
    }
}
