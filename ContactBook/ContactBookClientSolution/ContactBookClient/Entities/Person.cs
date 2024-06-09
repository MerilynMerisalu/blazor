using System.ComponentModel.DataAnnotations;

namespace ContactBookClient.Entities
{
    public class Person
    {
        public Guid PersonId { get; set; }

        [Required]
        [MaxLength(64)]
        [StringLength(64)]
        public string FirstName { get; set; } = default!;

        [Required]
        [MaxLength(64)]
        [StringLength(64)]
        public string LastName { get; set; } = default!;
    }
}
