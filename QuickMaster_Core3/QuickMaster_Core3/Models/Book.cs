using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuickMaster_Core3.Models
{
    public class Book : IValidatableObject
    {
        public int Id { get; set; }

        [DisplayName("Book Title")]
        [Required(ErrorMessage ="{0} is required.")]
        public string Title { get; set; }

        [DisplayName("Price($)")]
        [DataType(DataType.Currency)]
        [Range(0, 5000, ErrorMessage ="Enter {0} between {1} and {2}.")]
        public int Price { get; set; }

        [DisplayName("Publisher Name")]
        [StringLength(20, ErrorMessage ="Enter {0} less than or equal to {1}.")]
        public string Publisher { get; set; }

        [DisplayName("Sample?")]
        public bool Sample { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Publisher == "Free Novel" && this.Price > 0)
                // yield return new ValidationResult("The price of Free Novel must be $0.");
                yield return new ValidationResult("The price of Free Novel must be $0.", new[] { "Price" });
        }
    }
}
