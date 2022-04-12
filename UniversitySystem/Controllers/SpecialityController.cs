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

        public IActionResult Index(int id = 1)
        {
            var model = new SpecialityListViewModel
            {
                Specialities = this.specialityService.GetSpecialitiesForPage<SpecialityViewModel>(id, 20),
                PageNumber = id,
            };
            return View(model);
        }
    }
}
