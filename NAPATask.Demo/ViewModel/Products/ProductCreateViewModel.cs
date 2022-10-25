using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NAPATask.Demo.ViewModel.Products
{
    public class ProductCreateViewModel
    {
        [Display(Name = "Title ")]
        [Required(ErrorMessage = "Title is required ")]
        [MinLength(2), MaxLength(75)]
        public string Title { get; set; } = String.Empty;


        [Display(Name = "Quantiy ")]
        [Required(ErrorMessage = "Quantiy is required ")]
        public int Quantiy { get; set; }


        [Display(Name = "Price ")]
        [Required(ErrorMessage = "Price is required ")]
        public double Price { get; set; }

        public string? UserId { get; set; }
    }
}
