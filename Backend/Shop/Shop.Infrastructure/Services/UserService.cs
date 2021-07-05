using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Shop.Core.Domain;
using Shop.Core.Repositories;
using Shop.Infrastructure.Extensions;
using Shop.Infrastructure.Models;
using Shop.Infrastructure.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Shop.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IJwtService _jwtService;
        
        public UserService(IMapper mapper, IUserRepository userRepository, 
            IPasswordHasher<User> passwordHasher, IJwtService jwtService)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _jwtService = jwtService;
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
            var confirmedPassword = _passwordHasher.VerifyHashedPassword(user, user.Password, loginUserDTO.Password);
            if(confirmedPassword == PasswordVerificationResult.Failed)
            {
                throw new Exception("bledne haslo");
            }
           return _jwtService.CreateToken(user.Id, user.Email, user.Role);
            
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
            var user = _userRepository.GetUserAllreadyExists(id);
            _userRepository.DeleteUser(user.Id);
        }

    }
}
