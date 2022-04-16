namespace UniversitySystem.Models.UserModels
{
    using System.ComponentModel.DataAnnotations;

    public class UserViewModel
    {
        public string UserId { get; set; }

        [Required(ErrorMessage ="Полето за оценка не може да е празно")]
        [Range(2.00, 6.00, ErrorMessage = "Оценката трябва да е между 2.00 и 6.00")]
        public double BulgarianExam { get; set; }

        [Required(ErrorMessage = "Полето за оценка не може да е празно")]
        [Range(2.00, 6.00, ErrorMessage = "Оценката трябва да е между 2.00 и 6.00")]
        public double SecondExam { get; set; }

        [Required(ErrorMessage = "Полето за оценка не може да е празно")]
        [Range(2.00, 6.00, ErrorMessage = "Оценката трябва да е между 2.00 и 6.00")]
        public double AssesmentBulagrian { get; set; }

        [Required(ErrorMessage = "Полето за оценка не може да е празно")]
        [Range(2.00, 6.00, ErrorMessage = "Оценката трябва да е между 2.00 и 6.00")]
        public double AssesmentSecondSubject { get; set; }
    }
}
