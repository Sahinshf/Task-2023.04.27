using Microsoft.AspNetCore.Mvc;
using Task.Contexts;

namespace Task.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {

        private readonly AppDbContext _context;

        public SliderController(AppDbContext context)
        {
            _context = context;       
        }

        public IActionResult Index()
        {

            List<Slide> slides = _context.Slides.ToList();

            return View(slides);
        }

        public IActionResult Create() {
        
            return View();  
        }

        [HttpPost]
        public IActionResult Create(Slide slide)
        {
            _context.Slides.Add(slide);
            _context.SaveChanges();

            return View();
        }

    }
}
