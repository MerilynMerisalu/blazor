using Base.Domain;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.EF
{
    public class Contact : DomainEntityMetaId
    {
        public Guid ContactTypeId { get; set; }
        public ContactType? ContactType { get; set; }

        public Guid PersonId { get; set; }
        public Person? Person { get; set; }

        [Required]
        [MaxLength(64)]
        [StringLength(64)]
        public string ContactValue { get; set; } = default!;

    }
}