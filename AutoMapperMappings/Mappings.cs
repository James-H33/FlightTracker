using AutoMapper;
using FlightTracker.Models;

namespace FlightTracker.AutoMapperMappings
{
    public class Mappings : Profile
    {
        public Mappings() 
        {
            // CreateMap<AirportFromFile, Airport>()
            //     .ForMember(
            //     dest => dest.Value,
            //     opt => opt.MapFrom(src => src.Options[0].Value)
            // )
            // .ForMember(
            //     dest => dest.Type,
            //     opt => opt.MapFrom(src => src.MetaType)
            // );
        }
    }
}