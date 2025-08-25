using FileApiExample.ValidationsAttributes;
using System.ComponentModel.DataAnnotations;

namespace FileApiExample
{
    public class Profile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Range(1, 18)]

        public int Age { get; set; }

        [Required]
        [ExtentionValidation(new string[] { ".jpg", ".gif" })]
        public IFormFile ProfilePicture { get; set; }
    }
}
