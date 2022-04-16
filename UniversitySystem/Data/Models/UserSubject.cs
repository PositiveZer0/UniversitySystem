namespace UniversitySystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class UserSubject
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public IdentityUser User { get; set; }

        public int SubjectId { get; set; }

        public Subject Subject { get; set; }

        [Required]
        [Range(2.00, 6.00)]
        public double Grade { get; set; }
    }
}
