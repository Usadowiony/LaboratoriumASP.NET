using System.Collections.Generic;

namespace WebApp.Models
{
    public interface IContactService
    {
        int Add(ContactModel contact);
        void Delete(int id);
        void Update(ContactModel contact);
        List<ContactModel> FindAll();
        ContactModel? FindById(int id);
    }
}
