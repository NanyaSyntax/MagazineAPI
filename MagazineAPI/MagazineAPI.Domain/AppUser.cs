using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;

namespace MagazineAPI.Domain
{
    public class AppUser : IdentityUser
    {
        
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = new DateTime();

        public ICollection<Magazine> Magazines { get; set; }


    }
}
