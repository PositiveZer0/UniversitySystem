namespace UniversitySystem.Models.Contact
{
    using System.ComponentModel.DataAnnotations;

    public class ContactViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage ="Заглавието трябва да е поне 3 символа")]
        [Display(Name ="Заглавие")]
        public string Title { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 10, ErrorMessage ="Описанието трябва да е поне 10 символа")]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [EmailAddress(ErrorMessage ="Невалиден имейл")]
        [Display(Name ="Вашия имейл")]
        public string ClientEmail { get; set; }
    }
}
