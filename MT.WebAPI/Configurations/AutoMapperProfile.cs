using AutoMapper;
using MT.Data.Dtos;
using MT.Data.Models;

namespace MT.WebAPI.Configurations
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // lúc nào cần chuyển đổi cái gì thì vào đây thêm vào
            CreateMap<Attribute, AttributeDto>().ReverseMap();
            CreateMap<AttributeDto, Attribute>().ReverseMap();
            CreateMap<Monter, MonterDto>().ReverseMap();
            CreateMap<MonterDto, Monter>().ReverseMap();
            CreateMap<Skill , SkillDto>().ReverseMap();
            CreateMap<Skill, SkillDto>().ReverseMap();
            CreateMap<Type, TypeDto>().ReverseMap();
            CreateMap<TypeDto, Type>().ReverseMap();
            CreateMap<TypeSkill, TypeSkillDto>().ReverseMap();
            CreateMap<TypeSkillDto, TypeSkill>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<Authority, AuthorityDto>().ReverseMap();
            CreateMap<AuthorityDto, Authority>().ReverseMap();


        }
    }
}
