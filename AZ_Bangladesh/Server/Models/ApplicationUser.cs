using Microsoft.AspNetCore.Identity;

namespace AZ_Bangladesh.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string City { get; set; } = default!;

    }
}