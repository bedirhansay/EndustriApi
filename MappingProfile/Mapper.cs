using AutoMapper;
using EndustriApi.DTO;
using EndustriApi.Entity;

namespace EndustriApi.MappingProfile;

public class Mapper:Profile
{
    public Mapper()
    {
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        
    }
}