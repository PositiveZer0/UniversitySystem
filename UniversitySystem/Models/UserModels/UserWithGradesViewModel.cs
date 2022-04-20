namespace UniversitySystem.Models.UserModels
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections;
    using System.Collections.Generic;
    using UniversitySystem.Automapper;

    public class UserWithGradesViewModel : IMapFrom<IdentityUser>
    {
        public string Email { get; set; }

        public double TotalScore { get; set; }

        public IList<GradeViewModel> Grades { get; set; }
    }
}
