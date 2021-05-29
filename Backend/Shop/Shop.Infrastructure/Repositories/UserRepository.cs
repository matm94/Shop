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
    class UserRepository : IUserRepository
    {
        private readonly ShopDbContext _shopDbContext;
        public UserRepository(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public User GetUser(string login)
            => _shopDbContext.UserDbSet.SingleOrDefault(x => x.Login.ToLower() == login.ToLower());

        public User GetUser(Guid id)
            => _shopDbContext.UserDbSet.SingleOrDefault(x => x.Id == id);

        public IEnumerable<User> GetAll()
            => _shopDbContext.UserDbSet.ToList();

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
            _shopDbContext.Remove(user);
            _shopDbContext.SaveChanges();
        }
    }
}
