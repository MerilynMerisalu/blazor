using System.ComponentModel.DataAnnotations;

namespace App.Domain.EF
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int PersonId { get; set; }
        public Person? Person { get; set; }
        public int ContactTypeId { get; set; }
        public ContactType? ContactType { get; set; }

        [Required]
        [MaxLength(64)]
        [StringLength(64)]
        public string ContactValue { get; set; } = default!;
    }

    
}