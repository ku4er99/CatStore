using CatStore.WebMVC.Models.Domain.AuthenticationEntities;
using CatStore.WebMVC.Models.Domain.StoreEntities.PetEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CatStore.WebMVC.Models.Domain
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {

        }

        public DbSet<PetEntity> Pets { get; set; }
    }
}
