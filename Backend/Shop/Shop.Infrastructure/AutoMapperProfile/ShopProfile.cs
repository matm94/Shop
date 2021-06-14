using AutoMapper;
using Shop.Core.Domain;
using Shop.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.AutoMapperProfile
{
    public class ShopProfile : Profile
    {
        public ShopProfile()
        {
            CreateMap<User, UserDTO>()
                .ReverseMap();
            CreateMap<Order, OrderDTO>()
                .ReverseMap();
        }
    }
}
