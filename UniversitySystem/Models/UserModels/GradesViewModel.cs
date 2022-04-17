namespace UniversitySystem.Models.UserModels
{
    using System.ComponentModel.DataAnnotations;
    using UniversitySystem.Automapper;
    using UniversitySystem.Data.Models;

    public class GradesViewModel : IMapFrom<UserSubject>
    {
        public string UserId { get; set; }

        public double Grade { get; set; }
    }
}
