namespace UniversitySystem.Models.SpecialityModels
{
    using UniversitySystem.Automapper;
    using UniversitySystem.Data.Models;

    public class SpecialityViewModel : IMapFrom<Speciality>
    {
        public string Name { get; set; }

        public double MinimumScore { get; set; }

        public string UniversityName { get; set; }
    }
}
