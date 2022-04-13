namespace UniversitySystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using UniversitySystem.Models.SpecialityModels;
    using UniversitySystem.Models.UniversityModels;
    using UniversitySystem.Services;

    public class UniversityController : Controller
    {
        private IUniversityService universityService;
        private ISpecialityService specialityService;

        public UniversityController(IUniversityService universityService, ISpecialityService specialityService)
        {
            this.universityService = universityService;
            this.specialityService = specialityService;
        }

        public IActionResult Index()
        {
            var universities = this.universityService.GetAll<UniversityViewModel>();
            return View(universities);
        }

        public IActionResult Current(int id)
        {
            var currentUniversity = this.universityService.GetCurrent<CurrentUniversityViewModel>(id);
            currentUniversity.Specialities = this.specialityService
                .GetCurrentUniversitySpecialitiesForPage<SpecialityViewModel>(id, 5, 420);
            return View(currentUniversity);
        }
    }
}
