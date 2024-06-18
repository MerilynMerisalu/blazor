

using Base.Domain;
using System.ComponentModel.DataAnnotations;

namespace Application.Domain.EF
{
    public class Person : DomainEntityMetaId
    {
        
        public string FirstName { get; set; } = default!;

        
        public string LastName { get; set; } = default!;

        public string FirstAndLastName => $"{FirstName} {LastName}";
        public string LastAndFirstName => $"{LastName} {FirstName}";

        //public ICollection<Contact>? Contacts { get; set; }

    }
}
