using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            //(source, target)
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformReadDto, Platform>();
        }
    }
}
