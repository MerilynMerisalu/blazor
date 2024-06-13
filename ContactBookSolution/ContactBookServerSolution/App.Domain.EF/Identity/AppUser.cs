using Base.Domain.Identity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.EF.Identity
{
    public class AppUser : BaseUser
    {

        public string FirstName { get; set; } = default!;

        [Required()]
        [MaxLength(64)]
        [StringLength(64, MinimumLength = 1)]

        public string LastName { get; set; } = default!;

        public string FirstAndLastName => $"{FirstName} {LastName}";


        public string LastAndFirstName => $"{LastName} {FirstName}";
       
        [NotMapped]
        public IFormFile? ProfileImage { get; set; }

        [Required()]
        [DataType(DataType.EmailAddress)]
        [MaxLength(64)]
        [StringLength(64, MinimumLength = 1)]

        public override string? Email { get; set; }

        public ICollection<RefreshToken>? RefreshTokens { get; set; }
    }
}
