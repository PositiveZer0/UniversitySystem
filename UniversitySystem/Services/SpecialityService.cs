namespace UniversitySystem.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using UniversitySystem.Automapper;
    using UniversitySystem.Data;

    public class SpecialityService : ISpecialityService
    {
        private readonly ApplicationDbContext db;

        public SpecialityService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public ICollection<T> GetAll<T>()
        {
            return this.db.Specialities.To<T>().ToList();
        }

        public ICollection<T> GetSpecialitiesForPage<T>(int page, int count)
        {
            //0-19 page 1
            //20-39 page 2
            //40-59 page 3

            return this.db.Specialities.Skip(count * (page - 1)).Take(count).To<T>().ToList();
        }
    }
}
