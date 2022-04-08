namespace UniversitySystem.Data.Models
{
    using System.Collections.Generic;

    public class Speciality
    {
        public Speciality()
        {
            this.Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public double MinimumScore { get; set; }

        public IEnumerable<Subject> Subjects { get; set; }
    }
}
