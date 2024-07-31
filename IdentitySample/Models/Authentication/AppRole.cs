using Microsoft.AspNetCore.Identity;

namespace IdentitySample.Models.Authentication
{
    public class AppRole : IdentityRole
    {
        public DateTime CreatedDate { get; set; }
    }
}
