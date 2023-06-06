using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TextSplitterApp.Models;

namespace TextSplitterApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index(TextViewModel textViewModel)
        {
            return View(textViewModel);
        }

        [HttpPost]
        public IActionResult Split(TextViewModel textViewModel)
        {
            if (!ModelState.IsValid)
            {
                return this.RedirectToAction("Index", textViewModel);
            }

            string[] words = textViewModel.SplitText
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string splitText = String.Join(Environment.NewLine, words);
            textViewModel.SplitText = splitText;

            return this.RedirectToAction("Index", textViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}