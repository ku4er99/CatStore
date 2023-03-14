using Microsoft.AspNetCore.Identity;

namespace CatStore.WebMVC.Models.Domain.AuthenticationEntities {
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
