using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    // The line above is a route decorator -- it overrides needing to go to home/goodbye, instead just /goodbye
    public string Landing() { return "This is the landing page!"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/result")]
    public ActionResult Result(string name, string city)
    {
      ClassName instance = new ClassName("DefaultName");
      instance.Name = name;
      instance.City = city;
      return View(instance);
    }
  }
}