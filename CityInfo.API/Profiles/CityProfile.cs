using AutoMapper;
using CityInfo.API.Models.DTO;
using CityInfo.API.Models.Entites;

namespace CityInfo.API.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityWihoutPointOfInterestDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();       
        }
    }
}
