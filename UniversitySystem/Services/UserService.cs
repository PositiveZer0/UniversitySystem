namespace UniversitySystem.Services
{
    using System.Linq;
    using System.Threading.Tasks;

    using UniversitySystem.Data;
    using UniversitySystem.Data.Models;
    using UniversitySystem.Models.UserModels;

    public class UserService : IUserService
    {
        private ApplicationDbContext db;

        public UserService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task AddGrades(UserViewModel user)
        {
            var grades = this.db.UserSubjects.Where(x => x.UserId == user.UserId);
            this.db.UserSubjects.RemoveRange(grades);
            await this.db.SaveChangesAsync();

            await this.db.UserSubjects.AddAsync(new UserSubject
            {
                SubjectId = 1,
                UserId = user.UserId,
                Grade = user.BulgarianExam,
            });

            await this.db.UserSubjects.AddAsync(new UserSubject
            {
                SubjectId = 2,
                UserId = user.UserId,
                Grade = user.SecondExam,
            });

            await this.db.UserSubjects.AddAsync(new UserSubject
            {
                SubjectId = 3,
                UserId = user.UserId,
                Grade = user.AssesmentBulagrian,
            });

            await this.db.UserSubjects.AddAsync(new UserSubject
            {
                SubjectId = 4,
                UserId = user.UserId,
                Grade = user.AssesmentSecondSubject,
            });

            await this.db.SaveChangesAsync();
        }
    }
}
