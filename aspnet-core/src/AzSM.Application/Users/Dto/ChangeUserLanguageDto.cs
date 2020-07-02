using System.ComponentModel.DataAnnotations;

namespace AzSM.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}