using AutoMapper;
using Lamorenita.Data_Entities;
using Lamorenita.Models;

namespace Lamorenita
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<MODEL, ENTITY>()
            CreateMap<ProductTypeCreateModel, ProductTypeEntity>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Descripcion));

            CreateMap<ProductTypeEntity, ProductTypeViewModel>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Description));

        }
    }
}
