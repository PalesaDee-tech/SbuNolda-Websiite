using Microsoft.AspNetCore.Mvc;
using SbuNolda.Models;

namespace SbuNolda.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Services() => View();

        [HttpGet]
        public IActionResult Contact() => View(new ContactMessage());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactMessage model)
        {
            if (!ModelState.IsValid)
                return View(model);

            TempData["Success"] = "Thanks for reaching out! We'll get back to you within 24 hours.";
            return RedirectToAction(nameof(Contact));
        }
    }
}
