namespace UniversitySystem.Models.UserModels
{
    using System.ComponentModel.DataAnnotations;
    using UniversitySystem.Automapper;
    using UniversitySystem.Data.Models;

    public class GradesViewModel : IMapFrom<UserSubject>
    {
        public string UserId { get; set; }

        public int SubjectId { get; set; }
        [Required]
        [Range(2.00, 6.00, ErrorMessage ="Оценката трябва да е между 2.00 и 6.00")]
        public double Grade { get; set; }
    }
}
