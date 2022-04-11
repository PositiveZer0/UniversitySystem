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
    }
}
