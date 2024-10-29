using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

public class CalculatorController : Controller
{
    public IActionResult Form()
    {
        return View();
    }

    public IActionResult Result(Calculator model)
    {
        if (!model.IsValid())
        {
            return View("Error");
        }
        return View(model);
    }
}
