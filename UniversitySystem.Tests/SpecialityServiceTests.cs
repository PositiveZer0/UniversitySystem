namespace UniversitySystem.Tests
{
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using UniversitySystem.Data;
    using UniversitySystem.Data.Models;
    using UniversitySystem.Services;
    using Xunit;

    public class SpecialityServiceTests
    {
        public IList<Speciality> GetSpecialities()
        {
            return new List<Speciality>() {
            new Speciality{
                Id = 1,
                Name = "IT",
                MinimumScore = 20,
                UniversityId = 1
            },
                new Speciality{
                Id = 2,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
                new Speciality{
                Id = 3,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },new Speciality{
                Id = 4,
                Name = "IT",
                MinimumScore = 20,
                UniversityId = 1
            },
                new Speciality{
                Id = 5,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
                new Speciality{
                Id = 6,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
            new Speciality{
                Id = 7,
                Name = "IT",
                MinimumScore = 20,
                UniversityId = 1
            },
                new Speciality{
                Id = 8,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
                new Speciality{
                Id = 9,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
            new Speciality{
                Id = 10,
                Name = "IT",
                MinimumScore = 20,
                UniversityId = 1
            },
                new Speciality{
                Id = 11,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
                new Speciality{
                Id = 12,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
            new Speciality{
                Id = 13,
                Name = "IT",
                MinimumScore = 20,
                UniversityId = 1
            },
                new Speciality{
                Id = 14,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
                new Speciality{
                Id = 15,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
            new Speciality{
                Id = 16,
                Name = "IT",
                MinimumScore = 20,
                UniversityId = 1
            },
                new Speciality{
                Id = 17,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
                new Speciality{
                Id = 18,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
            new Speciality{
                Id = 19,
                Name = "IT",
                MinimumScore = 20,
                UniversityId = 1
            },
                new Speciality{
                Id = 20,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            },
                new Speciality{
                Id = 21,
                Name = "Law",
                MinimumScore = 25,
                UniversityId = 2
            }};
        }
        [Fact]
        public void SpecialityCountShouldBeThree()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "FakeSpecialities")
                .Options;
            ICollection<Speciality> result;
            using (var dbContext = new ApplicationDbContext(options))
            {
                dbContext.Database.EnsureCreated();
                dbContext.Specialities.AddRange(GetSpecialities());
                dbContext.SaveChanges();

                ISpecialityService specialityService = new SpecialityService(dbContext);
                result = specialityService.GetAll<Speciality>();
            }

            using (var dbContext = new ApplicationDbContext(options))
            {
                ISpecialityService specialityService = new SpecialityService(dbContext);
                result = specialityService.GetAll<Speciality>();
            }
            var specialityCount = result.Count();

           Assert.Equal(21, specialityCount);
        }


        public void SpecialitiesForPageShouldReturnTwentySpecialities()
        {

        }
    }
}
