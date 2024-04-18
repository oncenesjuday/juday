using Microsoft.AspNetCore.Mvc;

namespace Studentmanagementsystem.Controllers
{
    public class EnrollmentController : Controller
    {
        public IActionResult EnrollmentForm()
        {
            return View();
        }
    }
}
