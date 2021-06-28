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
            CreateMap<Collar, CollarDTO>()
                .ReverseMap();
            CreateMap<NormalLeash, NormalLeashDTO>()
                .ReverseMap();
            CreateMap<Order, OrderDTO>()
                .ReverseMap();
            CreateMap<Order, CompleteOrderDTO>()
                .ForMember(dst => dst.Collars, src => src.MapFrom(x => x.Product.Collars))
                .ForMember(dst => dst.NormalLeashes, src => src.MapFrom(x => x.Product.NormalLeashes))
                .ForMember(dst => dst.ReversibleLeashes, src => src.MapFrom(x => x.Product.ReversibleLeashes))
                .ForMember(dst => dst.Suspenders, src => src.MapFrom(x => x.Product.Suspenders))
                .ForMember(dst => dst.TrainingLeashes, src => src.MapFrom(x => x.Product.TrainingLeashes))
                .ReverseMap();
            CreateMap<Product, ProductDTO>()
                .ReverseMap();
            CreateMap<ReversibleLeash, ReversibleLeashDTO>()
                .ReverseMap();
            CreateMap<Suspenders, SuspendersDTO>()
                .ReverseMap();
            CreateMap<TapeBase, TapeBaseDTO>()
                .ReverseMap();
            CreateMap<TrainingLeash, TrainingLeashDTO>()
                .ReverseMap();
            CreateMap<User, UserDTO>()
                .ReverseMap();
        }
    }
}
