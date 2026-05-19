using System.ComponentModel.DataAnnotations;

namespace TravelGuide.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Регион")]
        public string Region { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Население")]
        public string Population { get; set; } = string.Empty;

        [Display(Name = "Краткое описание")]
        public string ShortDescription { get; set; } = string.Empty;

        [Display(Name = "История")]
        public string History { get; set; } = string.Empty;

        [Display(Name = "Фотография")]
        public string PhotoUrl { get; set; } = string.Empty;

        [Display(Name = "Герб")]
        public string CoatOfArmsUrl { get; set; } = string.Empty;

        public ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();
    }
}
