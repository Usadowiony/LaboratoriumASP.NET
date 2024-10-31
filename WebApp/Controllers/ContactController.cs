using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class ContactController : Controller
{
    private static Dictionary<int, ContactModel> _contacts = new()
    {
        {
            1, new ContactModel()
            {
                Id = 1,
                FirstName = "Wojciech",
                LastName = "Pietrzak",
                Email = "wojciechpietrzak@gmail.com",
                PhoneNumber = "123 456 789",
                BirthDate = new DateTime(2001, 2, 12),
            }
        },
        {
            2, new ContactModel()
            {
                Id = 2,
                FirstName = "Piotr",
                LastName = "Komun",
                Email = "piotr.komun@example.com",
                PhoneNumber = "123 456 789",
                BirthDate = new DateTime(1980, 1, 15),
            }
        },
        {
            3, new ContactModel()
            {
                Id = 3,
                FirstName = "Andrzej",
                LastName = "Kowalski",
                Email = "andrzej.kowalski@example.com",
                PhoneNumber = "123 456 789",
                BirthDate = new DateTime(2003, 6, 21),
            }
        },
        {
            4, new ContactModel()
            {
                Id = 4,
                FirstName = "Brat",
                LastName = "Smith",
                Email = "brat.smith@example.com",
                PhoneNumber = "123 456 789",
                BirthDate = new DateTime(1958, 5, 27),
            }
        }
    };

    private static int _currentId = 4;

    public IActionResult Index()
    {
        return View(_contacts);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(ContactModel model)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        model.Id = ++_currentId;
        _contacts.Add(model.Id, model);

        return View("Index", _contacts);
    }

    public IActionResult Delete(int id)
    {
        _contacts.Remove(id);
        return View("Index", _contacts);
    }

    public IActionResult Details(int id)
    {

        return View(_contacts[id]);
    }

    public IActionResult Back()
    {
        return View("Index", _contacts);
    }
}
