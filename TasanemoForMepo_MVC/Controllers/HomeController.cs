using Azure;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tass_PL.Models;

namespace Tass_PL.Controllers
{
    public class HomeController(ILogger<HomeController> logger) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;

    // داخل الـ Controller
    [HttpGet]
    public IActionResult SetLanguage(string language, string returnUrl)
    {
        if (!string.IsNullOrEmpty(language))
        {
            // حفظ اللغة المختارة في الكوكيز لكي يتذكرها المتصفح
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(language)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1),
                    IsEssential = true // ضروري لكي يعمل حتى لو كانت الكوكيز مقيدة
                }
            );
        }

        // العودة للصفحة التي كان فيها المستخدم
        return LocalRedirect(returnUrl ?? "/");
    }

    public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
