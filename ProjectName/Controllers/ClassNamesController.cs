using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class ClassNamesController : Controller
  {
    [HttpGet("/form")]
    public ActionResult Form() { return View(); }

    [HttpPost("/result")]
    public ActionResult Result(string name, string city)
    {
      ClassName instance = new ClassName("DefaultName");
      instance.Name = name;
      instance.City = city;
      return View(instance);
    }
  }
}