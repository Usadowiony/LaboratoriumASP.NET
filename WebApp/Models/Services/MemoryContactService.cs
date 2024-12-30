using System.Collections.Generic;
using System.Linq;
using Data.Entities;

namespace WebApp.Models.Services;
public class MemoryContactService : IContactService
{
    private static Dictionary<int, ContactModel> _contacts = new()
    {
        {
            1, new ContactModel()
            {
                Id = 1,
                FirstName = "Wojciech",
                LastName = "Pietrzak",
                Email = "wojciu@gmail.com",
                PhoneNumber = "669 996 696",
                BirthDate = new DateTime(year: 2003, month: 2, day: 28),
            }
        },
        {
            2, new ContactModel()
            {
                Id = 2,
                FirstName = "Artur",
                LastName = "Mue",
                Email = "arte@example.com",
                PhoneNumber = "111 111 111",
                BirthDate = new DateTime(2000, 1, 10),
            }
        },
        {
            3, new ContactModel()
            {
                Id = 3,
                FirstName = "Jan",
                LastName = "Kowalski",
                Email = "J.Kowalski@example.com",
                PhoneNumber = "222 222 222",
                BirthDate = new DateTime(1992, 1, 3),
            }
        }
    };
    private static int _currentId = 3;
    
    public void Add(ContactModel model)
    {
        model.Id = ++_currentId;
        _contacts.Add(model.Id, model);
    }
    public void Update(ContactModel contact)
    {
        if (_contacts.ContainsKey(contact.Id))
        {
            _contacts[contact.Id] = contact;
        }
    }
    public void Delete(int id)
    {
        _contacts.Remove(id);
    }
    public List<ContactModel> GetAll()
    {
        return _contacts.Values.ToList();
    }
    public ContactModel? GetById(int id)
    {
        return _contacts[id];
    }
    public List<OrganizationEntity> GetAllOrganizations()
    {
        throw new NotImplementedException();
    }
}