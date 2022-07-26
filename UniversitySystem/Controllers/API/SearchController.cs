// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversitySystem.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using UniversitySystem.Models.SpecialityModels;
    using UniversitySystem.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISpecialityService specialityService;

        public SearchController(ISpecialityService specialityService)
        {
            this.specialityService = specialityService;
        }

        // GET: api/<Search>
        [HttpGet]
        public SpecialityListViewModel Get()
        {
            var model = new SpecialityListViewModel
            {
                Specialities = this.specialityService.GetSpecialitiesForPage<SpecialityViewModel>(1, 20),
                PageNumber = 1,
                ItemsPerPage = 20,
                SpecialitiesCount = this.specialityService.GetSpecialityCount(),
            };

            return model;
        }

        //// GET api/<Search>/Авиационна
        [HttpGet("{searchedWord}")]
        public SpecialityListViewModel Get(string searchedWord)
        {
            var model = new SpecialityListViewModel
            {
                Specialities = this.specialityService.GetSpecialitiesForPage<SpecialityViewModel>(1, 20, searchedWord),
                PageNumber = 1,
                ItemsPerPage = 20,
                SpecialitiesCount = this.specialityService.GetSpecialityCount(),
            };

            return model;
        }
    }
}
