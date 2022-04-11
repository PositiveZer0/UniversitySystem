namespace UniversitySystem.Data.Seed
{
    using Microsoft.EntityFrameworkCore;
    using UniversitySystem.Data.Models;

    public static class Seeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasData(new Image
            {
                Id = 1,
                Name = "HTMUSO",
                Extension = "png"
            });
        }
    }
}
