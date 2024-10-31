using System.Collections.Generic;
using System.Linq;

namespace WebApp.Models
{
    public class MemoryContactService : IContactService
    {
        private readonly IDateTimeProvider _timeProvider;
        private readonly Dictionary<int, ContactModel> _contacts = new();

        public MemoryContactService(IDateTimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public int Add(ContactModel contact)
        {
            contact.Created = _timeProvider.GetCurrentDateTime();
            int newId = _contacts.Count + 1;
            contact.Id = newId;
            _contacts.Add(newId, contact);
            return newId;
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

        public ContactModel FindById(int id)
        {
            _contacts.TryGetValue(id, out var contact);
            return contact;
        }

        public IEnumerable<ContactModel> GetAll()
        {
            return _contacts.Values;
        }
    }
}
