using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace BlogWeb.Models
{
    public class BlogAddModel
    {
        public int AppUserId { get; set; }
        [Required(ErrorMessage = "Başlık alanı gereklidir")]
        [Display(Name = "Başlık :")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Açıklama alanı gereklidir")]
        [Display(Name = "Açıklama :")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Kısa Açıklama alanı gereklidir")]
        [Display(Name = "Kısa Açıklama :")]
        public string ShortDescription { get; set; }
        [Display(Name="Resim Seçiniz :")]
        public IFormFile Image { get; set; }

    }
}