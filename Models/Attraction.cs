using System.ComponentModel.DataAnnotations;

namespace TravelGuide.Models
{
    public class Attraction
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Название")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "История / Описание")]
        public string History { get; set; } = string.Empty;

        [Display(Name = "Фотография")]
        public string PhotoUrl { get; set; } = string.Empty;

        [Display(Name = "Часы работы")]
        public string WorkingHours { get; set; } = string.Empty;

        [Display(Name = "Стоимость посещения")]
        public string TicketPrice { get; set; } = string.Empty;

        [Required]
        public int CityId { get; set; }
        public City? City { get; set; }
    }
}
