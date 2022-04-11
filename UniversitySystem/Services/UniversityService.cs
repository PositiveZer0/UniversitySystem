namespace UniversitySystem.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using UniversitySystem.Automapper;
    using UniversitySystem.Data;
    using UniversitySystem.Models;

    public class UniversityService : IUniversityService
    {
        private readonly ApplicationDbContext db;

        public UniversityService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public ICollection<T> GetAll<T>()
        {
            //without automapper
            //var universities = this.db.Universities.Select(x => new UniversityViewModel
            //{
            //    Name = x.Name,
            //    Image = new ImageViewModel
            //    {
            //        Name = x.Image.Name,
            //        Extension = x.Image.Extension,
            //    },
            //});

            //with automapper
            var universities = this.db.Universities.To<T>();
            return universities.ToList();
            
        }
    }
}
