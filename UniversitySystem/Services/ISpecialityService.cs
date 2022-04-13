namespace UniversitySystem.Services
{
    using System.Collections.Generic;

    public interface ISpecialityService
    {
        ICollection<T> GetAll<T>();

        ICollection<T> GetSpecialitiesForPage<T>(int page, int count);

        int GetSpecialityCount();

    }
}
