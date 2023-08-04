using Microsoft.AspNetCore.Mvc;
using SchoolManagement1.Data;

namespace SchoolManagement1.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TeachersController(ApplicationDbContext context)
        {
            _context = context;  
        }

       public IActionResult Index()
        {
            return View();
        }
    }
}
