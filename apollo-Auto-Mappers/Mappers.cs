using apollo_Business_Entities.Models;
using apollo_DTO.Request;
using apollo_DTO.Response;
using AutoMapper;

namespace apollo_Auto_Mappers;
public static class Mappers
{
    public static IMapper mapper
    {
        get 
        {
            return AutoMapper.Mapper.Instance;
        }
    }
    static Mappers()
    {
        CreateMap(); 
    }
    public static void CreateMap()
    {
        AutoMapper.Mapper.Initialize(cfg =>
        {
            cfg.CreateMap<mst_user, UserResponseDTO>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.user_id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.user_name))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(source => source.email)).ReverseMap();

            cfg.CreateMap<UserRequestDTO,mst_user>()
            .ForMember(dest => dest.user_id, opt => opt.MapFrom(source => source.Id))
            .ForMember(dest => dest.user_name, opt => opt.MapFrom(source => source.Name))
            .ForMember(dest => dest.email, opt => opt.MapFrom(source => source.Email)).ReverseMap();
        });
    }
}