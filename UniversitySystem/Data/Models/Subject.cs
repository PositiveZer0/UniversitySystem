namespace UniversitySystem.Data.Models
{
    using System.Collections.Generic;

    public class Subject
    {
        public Subject()
        {
            this.UserSubjects = new HashSet<UserSubject>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<UserSubject> UserSubjects { get; set; }
    }
}
