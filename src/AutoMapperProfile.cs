﻿using AutoMapper;
using Lamorenita.Data_Entities;
using Lamorenita.Models;

namespace Lamorenita
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Product type
            CreateMap<ProductTypeEntity, ProductTypeViewModel>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Description));

            CreateMap<ProductTypeCreateModel, ProductTypeEntity>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Descripcion));


            //User
            CreateMap<UserEntity, UserViewModel>()
                .ForMember(dest => dest.Usuario, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.PrimerApellido, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.SegundoApellido, opt => opt.MapFrom(src => src.SecondLastName))
                .ForMember(dest => dest.FechaCreacion, opt => opt.MapFrom(src => src.Created))
                .ForMember(dest => dest.Activo, opt => opt.MapFrom(src => src.Active));

            CreateMap<UserCreateModel, UserEntity>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Usuario))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.PrimerApellido))
                .ForMember(dest => dest.SecondLastName, opt => opt.MapFrom(src => src.SegundoApellido));

            //Product
            CreateMap<ProductEntity, ProductViewModel>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.TipoProductoId, opt => opt.MapFrom(src => src.ProductTypeId))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Precio, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.Existencia, opt => opt.MapFrom(src => src.Stock))
                .ForMember(dest => dest.FechaCreacion, opt => opt.MapFrom(src => src.Created))
                .ForMember(dest => dest.Activo, opt => opt.MapFrom(src => src.Active))
                .ForMember(dest => dest.TipoProducto, opt => opt.MapFrom(src => src.ProductType.Name));


            CreateMap<ProductCreateModel, ProductEntity>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.ProductTypeId, opt => opt.MapFrom(src => src.TipoProductoId))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Descripcion))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Precio))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Existencia));

        }
    }
}
