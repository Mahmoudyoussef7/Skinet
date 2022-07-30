using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Product:BaseEntity
    {

        [Required(ErrorMessage ="the name is required")]
        [MaxLength(100,ErrorMessage ="maximum length is 100")]
        public string Name { get; set; }

        [Required]
        [MaxLength(200,ErrorMessage ="Maximum length is 200")]
        public string Description { get; set; }

        [Required]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public decimal Price { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public int ProductTypeId { get; set; }

        [Required]
        public int ProductBrandId { get; set; }

        public ProductType ProductType { get; set; }
        public ProductBrand ProductBrand { get; set; }
    }
}
