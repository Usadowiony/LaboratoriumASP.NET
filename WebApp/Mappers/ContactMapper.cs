using WebApp.Models;
using Data.Entities;


namespace WebApp.Mappers;

public class ContactMapper
{
    public static ContactModel FromEntity(ContactEntity entity)
    {
        return new ContactModel()
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            BirthDate = entity.BirthDate,
            Email = entity.Email,
            PhoneNumber = entity.PhoneNumber,
        };
    }

    public static ContactEntity ToEntity(ContactModel model)
    {
        return new ContactEntity()
        {
            Id = model.Id,
            FirstName = model.FirstName,
            LastName = model.LastName,
            BirthDate = model.BirthDate,
            Email = model.Email,
            PhoneNumber = model.PhoneNumber,
        };
    }
}