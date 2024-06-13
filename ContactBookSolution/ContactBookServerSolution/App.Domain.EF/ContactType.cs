using Base.Domain;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.EF
{
    public class ContactType: DomainEntityMetaId
    {
        [Required]
        [MaxLength(64)]
        [StringLength(64)]
        public string ContactTypeValue { get; set; } = default!;
    }
}