using CritoProject.Services;
using CritoProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace CritoProject.Controllers;

public class ContactController : SurfaceController
{
    private readonly ContactFormService _contactFormService;
    public ContactController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, ContactFormService contactFormService) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _contactFormService = contactFormService;
    }

    [HttpPost]
    public async Task<IActionResult> Index(ContactUsFormViewModel form)
    {
        if(ModelState.IsValid)
        {
            var response = await _contactFormService.AddForm(form);
            if(response != null) {
                ViewBag.Message = "We have recieved your message!";
                return RedirectToCurrentUmbracoPage(QueryString.Create("response", "We have recieved your message!"));
            }
            
        }
        
        return CurrentUmbracoPage();
    }
}
