namespace UniversitySystem.Models.UserModels
{
    using UniversitySystem.Automapper;
    using UniversitySystem.Data.Models;

    public class GradesViewModel : IMapFrom<UserSubject>
    {
        public string UserId { get; set; }

        public int SubjectId { get; set; }

        public double Grade { get; set; }
    }
}
