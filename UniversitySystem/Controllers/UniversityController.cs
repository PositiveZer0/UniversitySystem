namespace UniversitySystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using UniversitySystem.Models.UniversityModels;
    using UniversitySystem.Services;

    public class UniversityController : Controller
    {
        private IUniversityService universityService;

        public UniversityController(IUniversityService universityService)
        {
            this.universityService = universityService;
        }

        public IActionResult Index()
        {
            var universities = this.universityService.GetAll<UniversityViewModel>();
            return View(universities);
        }

        public IActionResult Current(int id)
        {
            var currentUniversity = this.universityService.GetCurrent<CurrentUniversityViewModel>(id);
            return View(currentUniversity);
        }
    }
}
