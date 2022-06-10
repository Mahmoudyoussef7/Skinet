using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Product
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage ="the name is required")]
        [MaxLength(50,ErrorMessage ="maximum length is 50")]
        public string Name { get; set; }
    }
}
