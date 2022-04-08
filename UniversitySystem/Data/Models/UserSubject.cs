namespace UniversitySystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class UserSubject
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        public IdentityUser User { get; set; }

        public int SubjectId { get; set; }

        public Subject Subject { get; set; }

        public double Grade { get; set; }
    }
}
