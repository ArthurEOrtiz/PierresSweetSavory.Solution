using Microsoft.AspNetCore.Mvc;
using PierresSweetSavory.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierresSweetSavory.Controllers
{
    public class HomeController : Controller
    {

      private readonly PierresSweetSavoryContext _db;
      public HomeController(PierresSweetSavoryContext db)
      {
        _db = db;
      }
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Treat> treatList = _db.Treats.ToList();
        ViewBag.Flavors = _db.Flavors.ToList();
        return View();
      }

    }
}