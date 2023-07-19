using AutoMapper;
using Backend.Data;
using Backend.Models.Character;

namespace Backend.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Character, CharacterRequest>().ReverseMap();
            CreateMap<Character, CharacterResponse>().ReverseMap();
        }
    }
}