using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using System.Collections.Generic;
using System.Linq;

public class ReservationController : Controller
{
    static Dictionary<int, Reservation> _reservations = new Dictionary<int, Reservation>();

    public IActionResult Index()
    {
        return View(_reservations);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Reservation model)
    {
        if (ModelState.IsValid)
        {
            int id = _reservations.Keys.Count != 0 ? _reservations.Keys.Max() : 0;
            model.Id = id + 1;
            _reservations.Add(model.Id, model);

            return RedirectToAction("Index");
        }
        else
        {
            return View(model);
        }
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        if (_reservations.ContainsKey(id))
        {
            return View(_reservations[id]);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost]
    public IActionResult Edit(Reservation model)
    {
        if (ModelState.IsValid)
        {
            _reservations[model.Id] = model;
            return RedirectToAction("Index");
        }
        else
        {
            return View(model);
        }
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        if (_reservations.ContainsKey(id))
        {
            return View(_reservations[id]);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        if (_reservations.ContainsKey(id))
        {
            _reservations.Remove(id);
            return RedirectToAction("Index");
        }
        else
        {
            return NotFound();
        }
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
        if (_reservations.ContainsKey(id))
        {
            return View(_reservations[id]);
        }
        else
        {
            return NotFound();
        }
    }
}
