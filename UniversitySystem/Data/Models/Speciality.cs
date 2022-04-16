namespace UniversitySystem.Data.Models
{
    using System.Collections.Generic;

    public class Speciality
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double MinimumScore { get; set; }

        public int UniversityId { get; set; }

        public University University { get; set; }
    }
}
