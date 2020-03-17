using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class SecondClassesController : Controller
  {
    private readonly DatabaseNameContext _db;

    public SecondClassesController(DatabaseNameContext db)
    {
      // _db is now equal to our databaseContext object
      _db = db;
    }

    public ActionResult Index()
    {
      // Get all our instances with _db.Instances.ToList()
      List<SecondClass> model = _db.SecondClasses.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      // Show form for creating new instance
      return View();
    }

    [HttpPost]
    public ActionResult Create(SecondClass instance)
    {
      // Add new instance to database
      _db.SecondClasses.Add(instance);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}