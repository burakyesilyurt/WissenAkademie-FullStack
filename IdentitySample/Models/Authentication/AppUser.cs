using Microsoft.AspNetCore.Identity;

namespace IdentitySample.Models.Authentication
{
    public class AppUser : IdentityUser
    {
        public string Country { get; set; }
        public bool Gender { get; set; }
    }
}
