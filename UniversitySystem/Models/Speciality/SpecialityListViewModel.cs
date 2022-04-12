namespace UniversitySystem.Models.Speciality
{
    using System.Collections.Generic;

    public class SpecialityListViewModel
    {
        public ICollection<SpecialityViewModel> Specialities { get; set; }

        public int PageNumber { get; set; }
    }
}
