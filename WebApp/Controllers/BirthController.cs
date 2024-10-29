using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

public class BirthController : Controller
{
    public IActionResult Form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Result([FromForm] Birth model)
    {
        if (!model.IsValid())
        {
            return View("Error");
        }

        ViewBag.Name = model.Name;
        ViewBag.Age = model.CalculateAge();
        return View();
    }
}
