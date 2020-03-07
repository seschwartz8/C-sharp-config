using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public string Landing() { return "Welcome to the site! This is the root route."; }

    [Route("/hello")]
    public string Hello() { return "Hello!"; }

    [Route("/goodbye")]
    // The line above is a route decorator -- it overrides needing to go to home/goodbye, instead just /goodbye
    public string Goodbye() { return "Goodbye!"; }
  }
}