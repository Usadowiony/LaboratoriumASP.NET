using System.Collections.Generic;
using System.Linq;

namespace WebApp.Models
{
    public class MemoryContactService : IContactService
    {
        private Dictionary<int, ContactModel> _items = new Dictionary<int, ContactModel>();

        public int Add(ContactModel contact)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            contact.Id = id + 1;
            _items.Add(contact.Id, contact);
            return contact.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<ContactModel> FindAll()
        {
            return _items.Values.ToList();
        }

        public ContactModel? FindById(int id)
        {
            _items.TryGetValue(id, out var contact);
            return contact;
        }

        public void Update(ContactModel contact)
        {
            _items[contact.Id] = contact;
        }
    }
}
