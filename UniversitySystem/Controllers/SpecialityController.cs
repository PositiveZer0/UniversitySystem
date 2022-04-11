namespace UniversitySystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using UniversitySystem.Models.Speciality;
    using UniversitySystem.Services;

    public class SpecialityController : Controller
    {
        private readonly ISpecialityService specialityService;

        public SpecialityController(ISpecialityService specialityService)
        {
            this.specialityService = specialityService;
        }

        public IActionResult Index()
        {
            var model = this.specialityService.GetAll<SpecialityViewModel>();
            return View(model);
        }
    }
}
