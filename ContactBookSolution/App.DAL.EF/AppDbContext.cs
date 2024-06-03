using App.Domain.EF;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; } = default!;
        public DbSet<Contact> Contacts { get; set; } = default!;
        public DbSet<ContactType> ContactTypes { get; set; } = default!;

    }
}
