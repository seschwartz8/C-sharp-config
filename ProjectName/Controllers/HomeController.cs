using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Landing()
    {
      ClassName instance = new ClassName("Sasa");
      instance.City = "Portland";
      string newName = "Tessa";
      instance.Name = newName;
      return View(instance);
    }

    [Route("/hello")]
    public string Hello() { return "Hello!"; }

    [Route("/goodbye")]
    // The line above is a route decorator -- it overrides needing to go to home/goodbye, instead just /goodbye
    public string Goodbye() { return "Goodbye!"; }
  }
}