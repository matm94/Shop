using Shop.Core.Domain;
using Shop.Core.Repositories;
using Shop.Db;
using Shop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KataShopTest.Repositories
{
    public class UserRepositoryTest
    {
        private readonly ShopDbContext _shopDbContext;
        [Fact]
        public void Whern_added_new_user_it_shuld_be_added_corectly()
        {

            //Arrange
            var user = new User("login", "password", "email");
            IUserRepository userRepository = new UserRepository(_shopDbContext);
            //Act
            userRepository.AddUser(user);

            //Asert
            var existUser = userRepository.GetUser(user.Id);
            Assert.Equal(user, existUser);
        }
    }
}
