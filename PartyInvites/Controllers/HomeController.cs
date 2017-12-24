using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
  public class HomeController : Controller
  {
    public ViewResult Index()
    {
      int hour = DateTime.Now.Hour;
      ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
      return View("MyView");
    }

    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
