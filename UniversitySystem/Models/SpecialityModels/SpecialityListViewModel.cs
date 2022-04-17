namespace UniversitySystem.Models.SpecialityModels
{
    using System;
    using System.Collections.Generic;

    public class SpecialityListViewModel 
    {
        public ICollection<SpecialityViewModel> Specialities { get; set; }

        public int PageNumber { get; set; }

        public int ItemsPerPage { get; set; }

        public int SpecialitiesCount { get; set; }

        public bool HasPrevious  => this.PageNumber > 1;

        public bool HasNext => this.PageNumber < this.PagesCount;

        public int PreviousPage => this.PageNumber - 1;

        public int NextPage => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((decimal)SpecialitiesCount / 20);

        public double Score { get; set; }
    }
}
