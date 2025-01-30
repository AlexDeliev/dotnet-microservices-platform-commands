using System.ComponentModel.DataAnnotations;

namespace Platform.Service.Dtos
{
    // This class is used to create a new platform
    public class PlatformCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Cost { get; set; }
    }
}