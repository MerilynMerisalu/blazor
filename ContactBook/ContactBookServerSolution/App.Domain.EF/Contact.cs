using System.ComponentModel.DataAnnotations;

namespace App.Domain.EF
{
    public class Contact
    {
        public Guid ContactId { get; set; }
        
        [Required]
        [MaxLength(64)]
        [StringLength(64)]
        public string ContactValue { get; set; } = default!;

        public Guid ContactTypeId { get; set; }
        public ContactType? ContactType { get; set; }

        public Guid PersonId { get; set; }
        public Person? Person { get; set; }
    }
}