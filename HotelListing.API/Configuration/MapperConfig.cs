using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig() 
        {
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<ApiUser,ApiUserDto>().ReverseMap();
            CreateMap<ApiUser, LoginDto>().ReverseMap();

        }
    }
}
