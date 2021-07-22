using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Shop.Core.Domain;
using Shop.Core.Repositories;
using Shop.Infrastructure.Extensions;
using Shop.Infrastructure.Models;
using System;
using System.Collections.Generic;

namespace Shop.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IJWTService _jWTService;
        private readonly ILogger<UserService> _logger;
        public UserService(IMapper mapper, IUserRepository userRepository, 
            IPasswordHasher<User> passwordHasher, IJWTService jwtService, ILogger<UserService> logger)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _jWTService = jwtService;
            _logger = logger;
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
        public void RegisterUser(RegisterUserDTO registerUserDTO)
        {
            _userRepository.GetUserNotExists(registerUserDTO.Email);
            var newUser = new User(registerUserDTO.Login, registerUserDTO.Password, registerUserDTO.Email, registerUserDTO.Role);
            newUser.Password = _passwordHasher.HashPassword(newUser, registerUserDTO.Password);
            _userRepository.AddUser(newUser);
        }
        public string LoginUser(LoginUserDTO loginUserDTO)
        {
            var user = _userRepository.GetUserAllreadyExists(loginUserDTO.Email);
            if (user == null)
            {
                throw new Exception("user can't be null");
            }

            return _jWTService.GenerateTokenJWT(user.Id,user.Login, user.Email, user.Role);

        }

        public void Create(string login, string password, string email, string role)
        {
            _userRepository.GetUserNotExists(email);
            var user = new User(login, password, email, role);
            _userRepository.AddUser(user);
        }
        public void Update(string login, string password, string email)
        {
            _userRepository.GetUserAllreadyExists(email);
            var user = new User(login, password, email);
            _userRepository.UpdateUser(user);
        }

        public void DeleteUser(Guid id)
        {
            _logger.LogError($"User with id: {id} DELETE action invoked");
            var user = _userRepository.GetUserAllreadyExists(id);
            _userRepository.DeleteUser(user.Id);
        }

    }
}
