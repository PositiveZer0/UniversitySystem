namespace UniversitySystem.Models.UniversityModels
{
    using UniversitySystem.Automapper;
    using UniversitySystem.Data.Models;
    using UniversitySystem.Models;

    public class UniversityViewModel : IMapFrom<University>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ImageInUniversityViewModel Image { get; set; }

    }
}
