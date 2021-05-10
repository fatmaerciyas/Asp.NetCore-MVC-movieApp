using CategoryApp.Data;
using Microsoft.AspNetCore.Mvc;


namespace MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
       
        }    
    }
}