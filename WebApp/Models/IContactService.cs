using System.Collections.Generic;

namespace WebApp.Models
{
    public interface IContactService
    {
        int Add(ContactModel contact);
        void Update(ContactModel contact);
        void Delete(int id);
        ContactModel FindById(int id);
        IEnumerable<ContactModel> GetAll();
    }
}
