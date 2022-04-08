namespace UniversitySystem.Data.Models
{
    using System.Collections.Generic;

    public class University
    {
        public University()
        {
            this.Specialities = new HashSet<Speciality>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string WebUrl { get; set; }

        public IEnumerable<Speciality> Specialities { get; set; }

        public Image Image { get; set; }
    }
}
