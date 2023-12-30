using MagazineAPI.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagazineAPI.Persistence
{
    public class MagazineDbContext : IdentityDbContext<AppUser>
    {
        public MagazineDbContext(DbContextOptions<MagazineDbContext> options ) : base(options) { }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
    }
}