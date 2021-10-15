using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ProductModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Please enter Image")]
        public string Img { get; set; }

        [Required(ErrorMessage = "Please enter product type")]
        [StringLength(maximumLength: 50, MinimumLength = 4, ErrorMessage = "Please enter more than 4 character")]
        public string ProductType { get; set; }
       
        [Required(ErrorMessage = "Please enter product name")]
        [StringLength(maximumLength: 50, MinimumLength = 4, ErrorMessage = "Please enter more than 4 character")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter product description")]
        [StringLength(maximumLength: 250, MinimumLength = 4, ErrorMessage = "Please enter more than 4 character")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Please enter product catagory")]
        [StringLength(maximumLength: 50, MinimumLength = 4, ErrorMessage = "Please enter more than 4 character")]
        public string ProductCategory { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductVolume { get; set; }
        public decimal Rating { get; set; }
    }
}
