using CritoProject.Context;
using CritoProject.Models.Entities;
using CritoProject.Services.Repositiories.Repos;
using CritoProject.ViewModels;
using Serilog.Context;
using Umbraco.Cms.Persistence.EFCore.Scoping;

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
