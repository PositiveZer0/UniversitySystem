namespace UniversitySystem.Models
{
    using UniversitySystem.Automapper;
    using UniversitySystem.Data.Models;

    public class ImageViewModel : IMapFrom<Image>
    {
        public string Name { get; set; }

        public string Extension { get; set; }
    }
}
