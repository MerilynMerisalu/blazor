using Base.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.EF.Identity
{
    public class RefreshToken: DomainEntityId
    {
        [StringLength(36, MinimumLength = 36)]
        public string Token { get; set; } = Guid.NewGuid().ToString();

        /* UTC */
        public DateTimeOffset TokenExpirationDateAndTime { get; set; } = DateTimeOffset.Now.AddDays(7);

        [StringLength(36, MinimumLength = 36)]
        public string? PreviousToken { get; set; }

        /* UTC */
        public DateTimeOffset? PreviousTokenExpirationDateAndTime { get; set; }

        [ForeignKey(nameof(AppUser))]
        public Guid? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}