using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class ClassNamesController : Controller
  {
    private readonly DatabaseNameContext _db;

    public ClassNamesController(DatabaseNameContext db)
    {
      // _db is now equal to our databaseContext object
      _db = db;
    }

    public ActionResult Index()
    {
      // Get all our instances with _db.Instances.ToList()
      List<ClassName> model = _db.ClassNames.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      // Show form for creating new instance
      return View();
    }

    [HttpPost]
    public ActionResult Create(ClassName instance)
    {
      // Add new instance to database
      _db.ClassNames.Add(instance);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      // Look through our ClassName database and return the instances that matche the id passed to this route
      ClassName thisClassName = _db.ClassNames.FirstOrDefault(instances => instances.ClassNameId == id);
      return View(thisItem);
    }
  }
}