namespace UniversitySystem.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Automapper;
    using Microsoft.EntityFrameworkCore;
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

        public ICollection<UserWithGradesViewModel> GetUsersAndGrades()
        {
            ICollection<UserWithGradesViewModel> userWithGrades = new List<UserWithGradesViewModel>();
            var users =  this.db.Users.Where(x => x.Email != "admin@admin.com").ToList();

            foreach (var user in users)
            {
                var grades = this.db.UserSubjects.Where(x => x.UserId == user.Id).Select(x => new GradeViewModel
                {
                    Grade = x.Grade,
                }).ToArray();

                if (grades.Count() != 4)
                {
                    continue;
                }
                var totalScore = 2 * (grades[0].Grade + grades[1].Grade) + grades[2].Grade + grades[3].Grade;

                userWithGrades.Add(new UserWithGradesViewModel
                {
                    Email = user.Email,
                    Grades = grades.ToList(),
                    TotalScore = Math.Round(totalScore, 2),
                });
            }

            return userWithGrades;
        }

        //public ICollection<T> GetUserGrades<T>(string userId)
        //{
        //    return this.db.UserSubjects.Where(x => x.UserId == userId).To<T>().ToList();
        //}
    }
}
