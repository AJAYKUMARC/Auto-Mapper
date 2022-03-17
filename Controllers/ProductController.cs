using Microsoft.AspNetCore.Mvc;
using ObjectMapper.Models.dto;
using ObjectMapper.Repository;

namespace ObjectMapper.Controllers
{
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        protected ResponseDto response;
        private IProductRepository productRepositry;
        public ProductController(IProductRepository productRepositry)
        {
            this.productRepositry = productRepositry;
            this.response = new ResponseDto();
        }
        [HttpGet]
        public object GetProducts()
        {
            try
            {
                var products = productRepositry.GetProducts();
                response.Result = products;
            }
            catch (Exception ex)
            {
                response.IsSucces = false;
                response.ErrorMessage = new List<string> { ex.InnerException.Message.ToString() };
                throw;
            }
            return response;
        }
    }
}
