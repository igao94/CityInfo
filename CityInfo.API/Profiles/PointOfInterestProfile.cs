using AutoMapper;
using CityInfo.API.Models.DTO;
using CityInfo.API.Models.Entites;

namespace CityInfo.API.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<PointOfInterest, PointOfInterestDto>().ReverseMap();
            CreateMap<PointOfInterest, PointOfInterestForCreationDto>().ReverseMap();
            CreateMap<PointOfInterest, PointOfInterestForUpdateDto>().ReverseMap();
        }
    }
}
