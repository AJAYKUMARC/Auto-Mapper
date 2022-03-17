using ObjectMapper.Models.dto;

namespace ObjectMapper.Repository
{
    public interface IProductRepository
    {
        public IList<ProductDto> GetProducts();
    }
}
