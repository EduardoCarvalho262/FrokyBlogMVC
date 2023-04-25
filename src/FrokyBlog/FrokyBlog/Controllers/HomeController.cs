using FrokyBlog.Data;
using FrokyBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FrokyBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FrokyBlogContext _context;

        public HomeController(ILogger<HomeController> logger, FrokyBlogContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var posts = from m in _context.Post
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                posts = posts.Where(s => s.Title!.Contains(searchString));
            }   

            return View(await posts.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}