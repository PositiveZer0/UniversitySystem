namespace UniversitySystem.Models.UniversityModels
{
    using UniversitySystem.Automapper;
    using UniversitySystem.Data.Models;

    public class ImageInUniversityViewModel : IMapFrom<Image>
    {
        public string Name { get; set; }

        public string Extension { get; set; }
    }
}
