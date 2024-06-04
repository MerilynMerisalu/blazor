using System.ComponentModel.DataAnnotations;

namespace ContactBookClient.DTO
{
    
        public class Person
        {
            public int PersonId { get; set; }

            [Required]
            [MaxLength(64)]
            [StringLength(64)]
            public string FirstName { get; set; } = default!;

            [Required]
            [MaxLength(64)]
            [StringLength(64)]
            public string LastName { get; set; } = default!;

            public string FirstAndLastName => $"{FirstName} {LastName}";
            public string LastAndFirstName => $"{LastName} {FirstName}";

            public ICollection<Contact>? Contacts { get; set; }
        }
}
