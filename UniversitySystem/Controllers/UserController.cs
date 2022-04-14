namespace UniversitySystem.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class UserController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
