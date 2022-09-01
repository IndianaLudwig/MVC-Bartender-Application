using Bartender.Data;
using Bartender.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bartender.Controllers
{
    public class BarController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BarController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        public IActionResult EditOrder()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menue()
        {
            IEnumerable<BarMenueModel> MenueList = _db.BarMenue;
            return View();
        }

        public IActionResult OrderQueue()
        {
            return View();
        }

        public IActionResult StaffLogin()
        {
            return View();
        }

        public IActionResult ViewOrder()
        {
            return View();
        }
    }
}
