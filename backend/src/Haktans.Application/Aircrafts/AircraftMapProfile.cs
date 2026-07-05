using AutoMapper;
using Haktans.Entities;
using Haktans.Aircrafts.Dto;

namespace Haktans.Aircrafts
{
    public class AircraftMapProfile : Profile
    {
        public AircraftMapProfile()
        {
            CreateMap<Aircraft, AircraftDto>();
            CreateMap<CreateAircraftDto, Aircraft>();
            CreateMap<AircraftDto, Aircraft>();
        }
    }
}
