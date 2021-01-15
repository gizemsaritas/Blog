using System.ComponentModel.DataAnnotations;

namespace BlogWeb.Models
{
    public class CategoryAddModel
    {
        [Required(ErrorMessage = "Ad alanı gereklidir")]
        [Display(Name = "Ad :")]
        public string Name { get; set; }

    }
}