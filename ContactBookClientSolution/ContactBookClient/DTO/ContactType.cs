using System.ComponentModel.DataAnnotations;

namespace ContactBookClient.DTO
{
    public class ContactType
    {
        public int ContactTypeId { get; set; }
        [Required]
        [MaxLength(64)]
        [StringLength(64)]
        public string ContactTypeName { get; set; } = default!;

        public ICollection<Contact>? Contacts { get; set; }
    }
}