namespace UniversitySystem.Models.UniversityModels
{
    using System.Collections.Generic;
    using UniversitySystem.Automapper;
    using UniversitySystem.Data.Models;
    using UniversitySystem.Models.SpecialityModels;

    public class CurrentUniversityViewModel : IMapFrom<University>
    {
        public string Name { get; set; }

        public string City { get; set; }

        public string WebUrl { get; set; }

        public ICollection<SpecialityViewModel> Specialities { get; set; }

        public ImageInUniversityViewModel Image { get; set; }

    }
}
