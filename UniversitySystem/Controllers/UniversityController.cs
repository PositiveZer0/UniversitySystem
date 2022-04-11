namespace UniversitySystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
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
            var universities = universityService.GetAll();
            return View(universities);
        }
    }
}
