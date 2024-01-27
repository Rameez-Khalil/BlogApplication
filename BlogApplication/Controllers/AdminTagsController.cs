using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.Controllers
{
    public class AdminTagsController : Controller
    {
        //We need to provide a form so user can fill it and 
        //our controller can use the data and inject it into our database.

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
