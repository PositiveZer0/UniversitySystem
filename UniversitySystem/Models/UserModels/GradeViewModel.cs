namespace UniversitySystem.Models.UserModels
{
    using UniversitySystem.Automapper;
    using UniversitySystem.Data.Models;

    public class GradeViewModel : IMapFrom<UserSubject>
    {
        public double Grade { get; set; }
    }
}
