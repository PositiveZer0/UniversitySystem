namespace UniversitySystem.Services
{
    using System.Collections;
    using System.Collections.Generic;
    using UniversitySystem.Models;

    public interface IUniversityService
    {
        ICollection<T> GetAll<T>();

        T GetCurrent<T>(int id);
    }
}
