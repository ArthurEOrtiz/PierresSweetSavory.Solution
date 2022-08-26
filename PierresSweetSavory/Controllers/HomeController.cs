using Microsoft.AspNetCore.Mvc;

namespace PierresSweetSavory.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}