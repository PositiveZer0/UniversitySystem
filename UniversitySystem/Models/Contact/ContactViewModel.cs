namespace UniversitySystem.Models.Contact
{
    using System.ComponentModel.DataAnnotations;

    public class ContactViewModel
    {
        [Display(Name ="Заглавие")]
        public string Title { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name ="Вашия емейл")]
        public string ClientEmail { get; set; }
    }
}
