using CritoProject.Models.Entities;
using CritoProject.Services.Repositiories.Repos;
using CritoProject.ViewModels;


namespace CritoProject.Services;

public class ContactFormService
{
    private readonly ContactFormRepo _db;

    public ContactFormService(ContactFormRepo db)
    {
        _db = db;
    }

    public async Task<ContactFormEntity> AddForm(ContactUsFormViewModel form)
    {
        ContactFormEntity formEntity = form;
        return await _db.AddOneAsync(formEntity);
    }
}
