namespace UniversitySystem.Models
{
    using UniversitySystem.Automapper;
    using UniversitySystem.Data.Models;

    public class UniversityViewModel : IMapFrom<University>
    {
        public string Name { get; set; }

        public ImageViewModel Image { get; set; }

    }
}
