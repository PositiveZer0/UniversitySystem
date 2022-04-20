namespace UniversitySystem.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using UniversitySystem.Models.UserModels;

    public interface IUserService
    {
        Task AddGrades(UserViewModel user);

        //ICollection<T> GetUserGrades<T>(string userId);

        ICollection<UserWithGradesViewModel> GetUsersAndGrades();
    }
}
