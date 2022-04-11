namespace UniversitySystem.Services
{
    using System.Collections.Generic;

    public interface ISpecialityService
    {
        ICollection<T> GetAll<T>();
    }
}
