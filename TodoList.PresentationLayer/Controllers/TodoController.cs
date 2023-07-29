using Microsoft.AspNetCore.Mvc;

namespace TodoList.PresentationLayer.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
