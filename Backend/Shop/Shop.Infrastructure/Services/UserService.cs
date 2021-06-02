using AutoMapper;
using Shop.Core.Domain;
using Shop.Core.Repositories;
using Shop.Infrastructure.Extensions;
using Shop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public UserDTO Get(string email)
        {
            var user = _userRepository.GetUserAllreadyExists(email);
            return _mapper.Map<UserDTO>(user);
        }

        public UserDTO Get(Guid id)
        {
            var user = _userRepository.GetUserAllreadyExists(id);
            return _mapper.Map<UserDTO>(user);
        }

        public IEnumerable<UserDTO> GetAll()
        {
            var allUser = _userRepository.GetAll();
            return _mapper.Map<IEnumerable<UserDTO>>(allUser);
        }

        public void Create(string login, string password, string email, string role)
        {
            _userRepository.GetUserNotExists(email);
            var user = new User(login, password, email, role);
            _userRepository.AddUser(user);
        }
        public void Update(string login, string password, string email)
        {
            var user = _userRepository.GetUserAllreadyExists(email);
            _userRepository.UpdateUser(user);
        }

        public void DeleteUser(Guid id)
        {
            var user = _userRepository.GetUserAllreadyExists(id);
            _userRepository.DeleteUser(user.Id);
        }

    }
}
