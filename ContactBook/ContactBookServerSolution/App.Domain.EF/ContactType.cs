using System.ComponentModel.DataAnnotations;

namespace App.Domain.EF
{
    public class ContactType
    {
        public Guid ContactTypeId { get; set; }

        [Required]
        [MaxLength(64)]
        [StringLength(64)]
        public string ContactTypeValue { get; set; } = default!;

        public ICollection<Contact>? Contacts { get; set; }
    }
}