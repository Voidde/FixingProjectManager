using System.ComponentModel.DataAnnotations;

namespace WebAPI.Dto
{
    public class AddLanguageDto
    {
        [Required]
        public string Name { get; set; }
    }
}
