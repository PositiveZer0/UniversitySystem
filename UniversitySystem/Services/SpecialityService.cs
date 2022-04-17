namespace UniversitySystem.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using UniversitySystem.Automapper;
    using UniversitySystem.Data;
    using UniversitySystem.Models;

    public class SpecialityService : ISpecialityService
    {
        private readonly ApplicationDbContext db;

        public SpecialityService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public ICollection<T> GetAll<T>()
        {
            return this.db.Specialities.OrderBy(x => x.Name).To<T>().ToList();
        }

        public ICollection<T> GetCurrentUniversitySpecialitiesForPage<T>(int id, int page, int count)
        {
            return this.db.Specialities.Where(x => x.UniversityId == id).OrderBy(x => x.Name).To<T>().ToList();
        }

        public ICollection<T> GetSpecialitiesForPage<T>(int page, int count)
        {
            //0-19 page 1
            //20-39 page 2
            //40-59 page 3

            return this.db.Specialities.OrderBy(x => x.Name).Skip(count * (page - 1)).Take(count).To<T>().ToList();
        }

        public int GetSpecialityCount()
        {
            return this.db.Specialities.Count();
        }

        public double GetUserScore(string userId)
        {
            var scoreList = this.db.UserSubjects.Where(x => x.UserId == userId).Select(x => x.Grade).ToArray();
            double totalScore = 2 *(scoreList[0] + scoreList[1]) + scoreList[2] + scoreList[3];

            return totalScore;
        }

        public bool UserHasGrades(string userId)
        {
            return this.db.UserSubjects.Where(x => x.UserId == userId).Count() == 4;
        }
    }
}
