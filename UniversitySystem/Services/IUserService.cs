namespace UniversitySystem.Services
{
    using System.Threading.Tasks;
    using UniversitySystem.Models.UserModels;

    public interface IUserService
    {
        Task AddGrades(UserViewModel user);
    }
}
