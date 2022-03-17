using System.ComponentModel.DataAnnotations;

namespace ObjectMapper.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string? ProductName { get; set; }
        public string ProductDescription { get; set; } = string.Empty;
    }
}
