namespace UniversitySystem.Controllers
{
    using System.Threading.Tasks;
    using System.Security.Claims;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using UniversitySystem.Services;
    using UniversitySystem.Models.UserModels;
    using Microsoft.AspNetCore.Identity;
    using UniversitySystem.Data;
    using System;

    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [Authorize]
        public IActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Index(UserViewModel user)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(user);
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            user.UserId = userId;
            await this.userService.AddGrades(user);

            var totalScoreUser = Math.Round(2 * (user.BulgarianExam + user.SecondExam) + user.AssesmentBulagrian + user.AssesmentSecondSubject, 2);
            return this.RedirectToAction(nameof(SuccessfullyAddGrades), new { totalScore = totalScoreUser});
        }

        [Authorize]
        public IActionResult All()
        {
            var usersAndGrades = this.userService.GetUsersAndGrades();
            return this.View(usersAndGrades);
        }

        public IActionResult SuccessfullyAddGrades(double totalScore)
        {
            this.ViewData["TotalScore"] = totalScore;
            return this.View();
        }
    }
}
