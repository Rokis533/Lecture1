using System.ComponentModel.DataAnnotations;

namespace FileApiExample.ValidationsAttributes
{
    public class ExtentionValidationAttribute : ValidationAttribute
    {
        private readonly string[] extentions;

        public ExtentionValidationAttribute(string[] extentions)
        {
            this.extentions = extentions;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {

                if (!extentions.Contains(Path.GetExtension(file.FileName)))
                {
                    return new ValidationResult("Netinka extention");
                }
            }
            return ValidationResult.Success;
        }
    }
}
