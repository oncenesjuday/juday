using Microsoft.AspNetCore.Mvc;

namespace Studentmanagementsystem.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Courses()
        {
            return View();
        }
    }
}
