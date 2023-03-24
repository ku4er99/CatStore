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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PetEntity>().HasData(new PetEntity[] { 
                new PetEntity
                {
                    //ProductProps                    
                    Id = 1,
                    Title = "Самый лучший кот!",
                    Description = "Всем привет, это самый луший кот, берите, непожелеете!",
                    Price = 10,
                    Image = "emptyCatImage.jpg", 

                    //PetProps
                    PetKind = Common.Enums.PetKinds.Cat,
                    Name = "Мурзик",
                    Age = 1,
                    IsLoving = true,
                    IsPlayful = true
                },
                new PetEntity
                {
                    //ProductProps                    
                    Id = 2,
                    Title = "Второй самый лучший кот!",
                    Description = "Всем привет, это самый луший кот, берите, непожелеете!",
                    Price = 10,
                    Image = "emptyCatImage.jpg", 

                    //PetProps
                    PetKind = Common.Enums.PetKinds.Cat,
                    Name = "Мурзик",
                    Age = 1,
                    IsLoving = true,
                    IsPlayful = true
                },
                new PetEntity
                {
                    //ProductProps                    
                    Id = 3,
                    Title = "Третий самый лучший кот!",
                    Description = "Всем привет, это самый луший кот, берите, непожелеете!",
                    Price = 10,
                    Image = "emptyCatImage.jpg", 

                    //PetProps
                    PetKind = Common.Enums.PetKinds.Cat,
                    Name = "Мурзик",
                    Age = 1,
                    IsLoving = true,
                    IsPlayful = true
                },
                new PetEntity
                {
                    //ProductProps                    
                    Id = 4,
                    Title = "Четвертый самый лучший кот!",
                    Description = "Всем привет, это самый луший кот, берите, непожелеете!",
                    Price = 10,
                    Image = "emptyCatImage.jpg", 

                    //PetProps
                    PetKind = Common.Enums.PetKinds.Cat,
                    Name = "Мурзик",
                    Age = 1,
                    IsLoving = true,
                    IsPlayful = true
                },
                new PetEntity
                {
                    //ProductProps                    
                    Id = 5,
                    Title = "Пятый самый лучший кот!",
                    Description = "Всем привет, это самый луший кот, берите, непожелеете!",
                    Price = 10,
                    Image = "emptyCatImage.jpg", 

                    //PetProps
                    PetKind = Common.Enums.PetKinds.Cat,
                    Name = "Мурзик",
                    Age = 1,
                    IsLoving = true,
                    IsPlayful = true
                },
                new PetEntity
                {
                    //ProductProps                    
                    Id = 6,
                    Title = "Шестой самый лучший кот!",
                    Description = "Всем привет, это самый луший кот, берите, непожелеете!",
                    Price = 10,
                    Image = "emptyCatImage.jpg", 

                    //PetProps
                    PetKind = Common.Enums.PetKinds.Cat,
                    Name = "Мурзик",
                    Age = 1,
                    IsLoving = true,
                    IsPlayful = true
                },
                new PetEntity
                {
                    //ProductProps                    
                    Id = 7,
                    Title = "Седьмой самый лучший кот!",
                    Description = "Всем привет, это самый луший кот, берите, непожелеете!",
                    Price = 10,
                    Image = "emptyCatImage.jpg", 

                    //PetProps
                    PetKind = Common.Enums.PetKinds.Cat,
                    Name = "Мурзик",
                    Age = 7,
                    IsLoving = true,
                    IsPlayful = true
                },
                new PetEntity
                {
                    //ProductProps                    
                    Id = 8,
                    Title = "Восьмой самый лучший кот!",
                    Description = "Всем привет, это самый луший кот, берите, непожелеете!",
                    Price = 10,
                    Image = "emptyCatImage.jpg", 

                    //PetProps
                    PetKind = Common.Enums.PetKinds.Cat,
                    Name = "Мурзик",
                    Age = 1,
                    IsLoving = true,
                    IsPlayful = true
                },

            });
        }
    }
}
