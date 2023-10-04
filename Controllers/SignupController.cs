using CritoProject.Services;
using CritoProject.Services.DatabaseServices;
using CritoProject.Services.Repositiories.Repos;
using CritoProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Media.EmbedProviders;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace CritoProject.Controllers
{
    public class SignupController : SurfaceController
    {
        private readonly SignupService _signupService;
        public SignupController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, SignupService signupService) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _signupService = signupService;
        }

        public async Task<IActionResult> Index(SignUpViewModel signupModel)
        {
            if (ModelState.IsValid)
            {
                var response = await _signupService.SignUpEmailToNewsLetter(signupModel);
                if (response != null)
                {
                    return RedirectToCurrentUmbracoPage(QueryString.Create("popUpMessage", $"The email {signupModel.Email} has been subscribed to our newsletter!"));
                }
                else
                {
                    return RedirectToCurrentUmbracoPage(QueryString.Create("popUpMessage", "That e-mail is already subscribed to our newsletter."));
                }
            }
            return RedirectToCurrentUmbracoPage(QueryString.Create("popUpMessage", "Please enter a valid e-mail."));
        }
    }
}
