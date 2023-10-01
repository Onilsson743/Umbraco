using CritoProject.Context;
using Serilog.Context;
using Umbraco.Cms.Persistence.EFCore.Scoping;

namespace CritoProject.Services;

public class ContactFormService
{
    private readonly DataContext _db;

    public ContactFormService(DataContext db)
    {
        _db = db;
    }

    public void AddForm()
    {
        
    }
}
