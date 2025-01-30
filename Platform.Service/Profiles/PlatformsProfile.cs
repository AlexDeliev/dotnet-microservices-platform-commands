using AutoMapper;
using Platform.Service.Dtos;
using Platform.Service.Models;

namespace Platform.Service.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target
            CreateMap<PlatformModel, PlatformReadDto>();
            CreateMap<PlatformCreateDto, PlatformModel>();
        }
    }
}