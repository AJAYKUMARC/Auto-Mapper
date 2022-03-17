using AutoMapper;
using ObjectMapper.dbContext;
using ObjectMapper.Models.dto;

namespace ObjectMapper.Repository
{

    public class ProductRepository : IProductRepository
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext context;
        public ProductRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public IList<ProductDto> GetProducts()
        {
            var products = context.Products.ToList();
            return mapper.Map<IList<ProductDto>>(products);
        }
    }
}
