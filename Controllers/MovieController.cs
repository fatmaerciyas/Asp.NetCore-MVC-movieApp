using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class MovieController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult Details()
        {
            // TODO: Your code here
            return View();
        }
        
        public IActionResult list()
        {
            // TODO: Your code here
            return View();
        }
        
        
    }
}