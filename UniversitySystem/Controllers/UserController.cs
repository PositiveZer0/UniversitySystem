namespace UniversitySystem.Controllers
{
    using System.Threading.Tasks;
    using System.Security.Claims;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using UniversitySystem.Services;
    using UniversitySystem.Models.UserModels;

    public class UserController : Controller
    {
        private IUserService userService;
        private readonly UserManager<IdentityUser> userManager;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [Authorize]
        public IActionResult Index()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Index(UserViewModel user)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(user);
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            user.UserId = userId;
            await this.userService.AddGrades(user);

            return this.Redirect("/");
        }
    }
}
