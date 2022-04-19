namespace UniversitySystem.Controllers
{
    using System.Linq;
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    using UniversitySystem.Data;
    using UniversitySystem.Models;
    using UniversitySystem.Models.UniversityModels;
    using UniversitySystem.Models.Contact;
    using System.Threading.Tasks;
    using UniversitySystem.Sendgrid;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;
        private readonly SendGridEmailSender sendGridEmail;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
            this.sendGridEmail = new SendGridEmailSender(ConfigurationConstants.SENDGRID_APIKEY);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            await sendGridEmail.SendEmailAsync
                (ConfigurationConstants.EMAIL, "University System", ConfigurationConstants.EMAIL, model.Title, $"Email sender: {model.ClientEmail}" + model.Description);
            return this.Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
