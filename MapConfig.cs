using AutoMapper;
using ObjectMapper.Models;
using ObjectMapper.Models.dto;

namespace ObjectMapper
{
    public class MapConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mapConfiguration = new MapperConfiguration(config =>
             {

                 //config.CreateMap<ProductDto, Product>().ReverseMap();
                 config.CreateMap<ProductDto, Product>();
                 config.CreateMap<Product, ProductDto>();
             });
            return mapConfiguration;
        }
    }
}
