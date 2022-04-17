namespace UniversitySystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;
    using UniversitySystem.Models.SpecialityModels;
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
            const int itemPerPage = 20;
            if (id < 1)
            {
                //return error
                return this.Redirect("");
            }

            var model = new SpecialityListViewModel
            {
                Specialities = this.specialityService.GetSpecialitiesForPage<SpecialityViewModel>(id, itemPerPage),
                PageNumber = id,
                ItemsPerPage = itemPerPage,
                SpecialitiesCount = this.specialityService.GetSpecialityCount(),
            };

            if (User.Identity.IsAuthenticated)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (this.specialityService.UserHasGrades(userId))
                {
                    model.Score = this.specialityService.GetUserScore(userId);
                }
            }

            return View(model);
        }
    }
}
